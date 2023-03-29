using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
using CANAnalyserApp;

namespace CAN_Software
{

	public partial class CANAnalyser : Form
	{
		public List<string> filteredIDs { get; set; }
		public List<string> focusedIDs { get; set; }
		public List<string> dataList { get; set; }
		public List<string> knownIDs { get; set; }
		public string dataIn { get; set; }


		System.Windows.Forms.Timer tm;
		

		bool SerialPortPendingClose = false;

		CANAnalyserInterface CANClass = new CANAnalyserInterface();

		public CANAnalyser()
		{
			
			loginPage LoginPage = new loginPage();
			LoginPage.Activate();
			LoginPage.ShowDialog();
			
			InitializeComponent();
			fillStaticBoxes();
			openButton.Enabled = false;
			closeButton.Enabled = false;
			pauseButton.Enabled = false;
			filteredIDs = new List<string>();
			focusedIDs = new List<string>();
			dataList = new List<string>();
			knownIDs = new List<string>();
			SerialPortPendingClose = false;

			dataIn = string.Empty;

		}
		
		public void fillStaticVoid()
		{

		}
		void tm_Tick(object sender, EventArgs e)
		{

			serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
		}
		
		

		public void fillStaticBoxes()
		{
			CANClass.FillMakeBox(makeSelectionBox);
			CANClass.FillModelBox(modelSelectionBox, makeSelectionBox);
			CANClass.FillEngineSize(engineSizeBox);
			CANClass.FillTransmissionType(transmissionTypeBox);
			CANClass.FillDriveTrain(drivetrainBox);
			CANClass.FillBaudRates(baudSelect);
			CANClass.FillPorts(portSelect);
			CANClass.FillRegYear(regYearSelectionBox);
			CANClass.FillFuelType(fuelTypeBox);

		}
		
		

		public void focusIDs()
		{
			if (focusedIDs.Count > 0)
			{
				List<string> temp = new List<string>();
				List<string> temp2 = new List<string>();
				temp2 = dataList;
				
				foreach (var focusID in focusedIDs)
				{
					dataList = temp2;
					dataList.RemoveAll(x => !x.Contains(focusID));
					foreach (var data in dataList)
					{
						temp.Add(data);

					}
				}
				dataList = temp;
			}
		}
		public void filterIDs()
		{
			//HashSet<string> toRemove = new HashSet<string>(File.ReadLines("FILTERIDS.txt"));
			foreach (var filterID in filteredIDs)
			{
				dataList.RemoveAll(x => x.Contains(filterID));
			}

		}
		private void port_DataReceived(object sender,
							 SerialDataReceivedEventArgs e) //reads and displays serialport data
		{
			if (!SerialPortPendingClose)
			{

				// Show all the incoming data in the port's buffer in the output window
				dataIn = serialPort.ReadExisting();
				dataList = dataIn.Split('\n').ToList();

				focusIDs();
				filterIDs();
				Thread.Sleep(150);
				AppendCanText(String.Join("\n", dataList.Where(x => x.StartsWith("ID") && x.Contains("Data"))));
			}
		}
		delegate void SetTextCallback(string text);

		private void AppendCanText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.CANText.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(AppendCanText);
				this.BeginInvoke(d, new object[] { text });
			}
			else
			{
				if (text.Length < 55)
				{
					this.CANText.AppendText(text);
				}
			}
		}

		public void timerCreate() // Creates timer for interval of data displayed
		{
			tm = new System.Windows.Forms.Timer();
			tm.Tick += new EventHandler(tm_Tick);
			tm.Interval = 150; //in ms
			tm.Enabled = true;
		}



		private void Form1_Load(object sender, EventArgs e)
		{


		}
		private void CANText_TextChanged(object sender, EventArgs e)            //autoscroll
		{
			CANText.SelectionStart = CANText.Text.Length;
			CANText.ScrollToCaret();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			portSelect.Enabled = true;
			baudSelect.Enabled = true;
			tm.Stop();
			SerialPortPendingClose = true;
			Thread.Sleep(serialPort.ReadTimeout); //Wait for reading threads to finish
			serialPort.Close();
			SerialPortPendingClose = false;
			openButton.Enabled = true;
			closeButton.Enabled = false;
			CANText.Clear();

			CANText.Text = "CLOSING PORT \n";
		}//close button


		private void openButton_Click(object sender, EventArgs e) //Open Button
		{
			portSelect.Enabled = false;
			baudSelect.Enabled = false;


			CANText.Clear();
			serialPort.PortName = Convert.ToString(portSelect.SelectedItem);
			serialPort.BaudRate = Convert.ToInt32(baudSelect.SelectedItem);
			serialPort.DtrEnable = true;
			serialPort.NewLine = "\n";
			openButton.Enabled = false;
			closeButton.Enabled = true;
			pauseButton.Enabled = true;
			serialPort.ReadTimeout = 150; //[ms] Time out if Read operation does not finish
			serialPort.Open();
			timerCreate();
		}


		private void filterButton_Click(object sender, EventArgs e) //filter button
		{
			string filteredID;

			filteredID = "ID " + filterBox.Text;
			if (filterBox.Text.Length != 0 && !(filterList.Text.Contains(filteredID)))
			{
				filteredIDs.Add(filteredID);

				filterList.AppendText("FILTERED - " + filteredID + "\r\n");
				filterBox.Clear();
			}
		}
		private void focusButton_Click(object sender, EventArgs e) //focus button
		{
			string focusedID;
			focusedID = "ID " + focusBox.Text;
			if (focusBox.Text.Length != 0 && !(filterList.Text.Contains(focusedID)))
			{

				focusedIDs.Add(focusedID);
				filterList.AppendText("FOCUSED - " + focusedID + "\r\n");
				focusBox.Clear();
			}
		}


		private void filterBox_TextChanged(object sender, EventArgs e) //filter enter box
		{
			this.filterBox.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnterFilter);
		}
		private void CheckEnterFilter(object sender, System.Windows.Forms.KeyPressEventArgs e) //enables enter for filter
		{
			if (e.KeyChar == (char)Keys.Enter && filterBox.Text.Length != 0)
			{
				filterButton_Click(this, new EventArgs());

			}
		}
		private void CheckEnterFocus(object sender, System.Windows.Forms.KeyPressEventArgs e) //enables enter for focus
		{
			if (e.KeyChar == (char)Keys.Enter && focusBox.Text.Length != 0)
			{
				focusButton_Click(this, new EventArgs());

			}
		}

		private void focusBox_TextChanged(object sender, EventArgs e) //focus enter box
		{
			this.focusBox.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnterFocus);
		}

		private void pauseButton_Click(object sender, EventArgs e) //startstop
		{
			if (serialPort.IsOpen)
			{
				tm.Stop();
				SerialPortPendingClose = true;
				Thread.Sleep(serialPort.ReadTimeout); //Wait for reading threads to finish
				serialPort.Close();
				SerialPortPendingClose = false;
				Thread.Sleep(300);

				CANText.AppendText("\n\r PAUSED");
				openButton.Enabled = false;
				closeButton.Enabled = true;
			}
			else
			{
				serialPort.PortName = Convert.ToString(portSelect.SelectedItem);
				serialPort.BaudRate = Convert.ToInt32(baudSelect.SelectedItem);
				serialPort.DtrEnable = true;
				serialPort.NewLine = "\n\r";
				openButton.Enabled = false;
				closeButton.Enabled = true;
				serialPort.ReadTimeout = 100; //[ms] Time out if Read operation does not finish
				serialPort.Open();
				timerCreate();
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			filteredIDs.Clear();
			focusedIDs.Clear();
			filterList.Clear();
		}

		private void portSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (portSelect.SelectedItem != null)
			{
				openButton.Enabled = true;
			}
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void viewToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void baudSelect_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void filterList_TextChanged(object sender, EventArgs e)
		{

		}

		private void focusButton_Click_1(object sender, EventArgs e)
		{
			string focusedID;
			focusedID = "ID " + focusBox.Text;
			if (focusBox.Text.Length != 0 && !(filterList.Text.Contains(focusedID)))
			{

				focusedIDs.Add(focusedID);
				filterList.AppendText("FOCUSED - " + focusedID + "\r\n");
				focusBox.Clear();
			}
		}
	

		private void analyserTab_Click(object sender, EventArgs e)
		{

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			CANClass.FillModelBox(modelSelectionBox, makeSelectionBox);
		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void profileSave_Click(object sender, EventArgs e)
		{
			CANClass.SaveProfile(makeSelectionBox, modelSelectionBox, regYearSelectionBox, engineSizeBox, fuelTypeBox, transmissionTypeBox, drivetrainBox);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			string root = @"C:\CarProfiles\";
			// If directory does not exist, create it.
			if (!Directory.Exists(root))
			{
				Directory.CreateDirectory(root);
			}
			string fullname = ($"{regYearSelectionBox.Text} {makeSelectionBox.Text} {modelSelectionBox.Text} {engineSizeBox.Text}L {fuelTypeBox.Text} {transmissionTypeBox.Text} {drivetrainBox.Text}.txt");
			string filePath = root + fullname;

			using (StreamWriter writer = new StreamWriter(filePath))
			{
				foreach (var id in knownIDs)
				{
					writer.Write(id);
				}
				writer.Write(CANText.Text);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string idString = $"ID {idInput.Text}: {functionInput.Text}\n";
			knownIDs.Add(idString);
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			fillStaticBoxes();
		}

		private void regYearLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
