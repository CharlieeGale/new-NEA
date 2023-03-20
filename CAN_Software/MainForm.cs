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





namespace CAN_Software
{

	public partial class CANAnalyser : Form
	{
		List<string> filteredIDs = new List<string>();
		List<string> focusedIDs = new List<string>();
		List<string> dataList = new List<string>();
				
		bool SerialPortPendingClose = false;
		public CANAnalyser()
		{
			loginPage LoginPage = new loginPage();
			LoginPage.Activate();
			LoginPage.ShowDialog();
			
			InitializeComponent();
			openButton.Enabled = false;
			closeButton.Enabled = false;
			pauseButton.Enabled = false;
		}
		string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
		System.Windows.Forms.Timer tm;
		string dataIn;
		void tm_Tick(object sender, EventArgs e)
		{

			serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
		}
		public void fillStaticBoxes()
		{
			fillPorts();
			fillBaudRates();
			fillMakeBox();
			fillModelBox();
			fillRegYear();

		}
		public void fillMakeBox()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open(); // opens connection to the database
				List<String> makes = new List<string>();
				string makesQuery = "SELECT makeName from makes";
				using (SqlCommand makesSearch = new SqlCommand(makesQuery, connection))
				{
					using (SqlDataReader myReader = makesSearch.ExecuteReader())
						while (myReader.Read()) // loops to add all values read to a list.
						{
							makes.Add(myReader.GetString(0));
						}
				}

				while (makeSelection.SelectedItem != null)
				{
					List<String> filteredMakes = new List<string>();
					string searchMakesQuery = $"Select makeName from makes WHERE makeName LIKE {makeSelection.SelectedItem} %";
					using (SqlCommand searchMakesSearch = new SqlCommand(searchMakesQuery, connection))
					{
						using (SqlDataReader myReaderFilter = searchMakesSearch.ExecuteReader())
							while (myReaderFilter.Read())
							{
								makes.Add(myReaderFilter.GetString(0));
							}
					}
					makes = filteredMakes;

				}
				makeSelection.DataSource = makes;
			}




		}
		public void fillModelBox()
		{

		}
		public void fillRegYear()
		{

		}
		public void fillEngineSize()
		{

		}
		public void fillFuelType()
		{

		}
		public void fillTransmissionType()
		{

		}
		public void fillDriveTrain()
		{

		}


		public void fillBaudRates()
		{
			int[] baudRates = new int[] { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 74880, 115200, 230400, 250000, 500000, 1000000 };
			baudSelect.DataSource = baudRates;
		}
		public void focusIDs()
		{
			foreach(var focusID in focusedIDs)
			{
				dataList.RemoveAll(x => !x.Contains(focusID));
				
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
				Thread.Sleep(150);
				// Show all the incoming data in the port's buffer in the output window
				dataIn = serialPort.ReadExisting();
				dataList = dataIn.Split('\n').ToList();
				//File.WriteAllText("CANDATA.txt", dataIn);
				//	string filteredData = filterIDs(File.ReadAllText(tempFile));
				focusIDs();
				filterIDs();
				/*foreach (var data in dataList)
				{
					AppendCanText(data);
				
				}*/
				AppendCanText(String.Join("\n" , dataList.Where(x => x.StartsWith("ID") && x.Contains("Data"))));
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
				this.CANText.AppendText(text);
			}
		}

		public void timerCreate() // Creates timer for interval of data displayed
		{
			tm = new System.Windows.Forms.Timer();
			tm.Tick += new EventHandler(tm_Tick);
			tm.Interval = 100; //in ms
			tm.Enabled = true;
		}

		public void fillPorts() // Displays available ports in combobox (portSelect) 
		{
			string[] ports = SerialPort.GetPortNames();
			portSelect.DataSource = ports;

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


			CANText.Clear();
			serialPort.PortName = Convert.ToString(portSelect.SelectedItem);
			serialPort.BaudRate = Convert.ToInt32(baudSelect.SelectedItem);
			serialPort.DtrEnable = true;
			serialPort.NewLine = "\n";
			openButton.Enabled = false;
			closeButton.Enabled = true;
			pauseButton.Enabled = true;
			serialPort.ReadTimeout = 200; //[ms] Time out if Read operation does not finish
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
			
				filterList.AppendText("FILTERED - "+filteredID+"\r\n");
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
				CANText.AppendText("\r\n PAUSED");
				SerialPortPendingClose = false;
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
			focusedIDs .Clear();
			filterList.Clear();
		}

		private void portSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			openButton.Enabled = true;
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

		}

		private void analyserTab_Click(object sender, EventArgs e)
		{

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

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
	}

}