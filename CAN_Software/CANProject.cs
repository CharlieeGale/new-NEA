using CAN_Software;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace CANAnalyserApp
{

    public class CANAnalyserInterface
    {

        public bool SerialPortPendingClose { get; set; }
        public string ConnectionString { get; set; }


        

        public CANAnalyserInterface()
        {

            SerialPortPendingClose = false;
            ConnectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";

        }

        public void FillPorts(ComboBox comboBox)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox.Items.AddRange(ports);
        }

        public void FillBaudRates(ComboBox comboBox)
        {
            comboBox.Items.Add(9600);
            comboBox.Items.Add(14400);
            comboBox.Items.Add(19200);
            comboBox.Items.Add(28800);
            comboBox.Items.Add(38400);
            comboBox.Items.Add(57600);
            comboBox.Items.Add(115200);
        }

        public void FillMakeBox(ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

                while (comboBox.SelectedItem != null)
                {
                    List<String> filteredMakes = new List<string>();
                    string searchMakesQuery = "Select makeName from makes WHERE makeName LIKE @makeSelection %";
                    using (SqlCommand searchMakesSearch = new SqlCommand(searchMakesQuery, connection))
                    {
                        searchMakesSearch.Parameters.Add("@makeSelection", System.Data.SqlDbType.VarChar, 255).Value = comboBox.SelectedItem;
                        using (SqlDataReader myReaderFilter = searchMakesSearch.ExecuteReader())
                            while (myReaderFilter.Read())
                            {
                                makes.Add(myReaderFilter.GetString(0));
                            }
                    }
                    makes = filteredMakes;

                }
                comboBox.DataSource = makes;
            }
        }

        public void FillModelBox(ComboBox comboBox, ComboBox comboBox1)
        {

            int desiredMake = 0;
            List<String> models = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open(); // opens connection to the database

                string makesQuery = "SELECT MakeID from makes where makeName = @makeName";
                string modelsQuery = "SELECT modelName from models where makeID = @makeID";
                using (SqlCommand makesSearch = new SqlCommand(makesQuery, connection))
                {
                    makesSearch.Parameters.Add("@makeName", System.Data.SqlDbType.VarChar, 255).Value = comboBox1.SelectedItem;

                    using (SqlDataReader myReader = makesSearch.ExecuteReader())
                    {
                        while (myReader.Read()) // loops to add all values read to a list.
                        {
                            desiredMake = myReader.GetInt32(0);
                        }
                    }
                }
                if (desiredMake != 0)
                {
                    using (SqlCommand modelSearch = new SqlCommand(modelsQuery, connection))
                    {
                        modelSearch.Parameters.Add("@makeID", System.Data.SqlDbType.VarChar, 255).Value = desiredMake;

                        using (SqlDataReader myReader = modelSearch.ExecuteReader())
                        {
                            while (myReader.Read()) // loops to add all values read to a list.
                            {
                                models.Add(myReader.GetString(0));
                            }
                        }
                    }
                }

            }
            comboBox.DataSource = models;
        }

        public void FillRegYear(ComboBox comboBox)
        {
            List<int> regYears = new List<int>();
            for (int i = 2023; i > 1900; i--)
            {
                regYears.Add(i);
            }
            comboBox.DataSource = regYears;
        }

        public void FillEngineSize(ComboBox comboBox)
        {
            List<String> engineSizes = new List<String>();
            decimal temp = 0.3M;

            while (temp < 10)
            {

                temp = temp + 0.1M;
                Decimal.Round(temp);
                engineSizes.Add(temp.ToString());
            }
            comboBox.DataSource = engineSizes;
        }

        public void FillFuelType(ComboBox comboBox)
        {
            string[] fuelTypes = new string[] { "Petrol", "Diesel", "LPG", "Electric", "Hybrid" };
            comboBox.DataSource = fuelTypes;
        }

        public void FillTransmissionType(ComboBox comboBox)
        {
            string[] transmissionTypes = new string[] { "Manual", "Automatic", "CVT", "Tiptronic", "Semi-Automatic" };
            comboBox.DataSource = transmissionTypes;
        }

        public void FillDriveTrain(ComboBox comboBox)
        {
            string[] driveTrains = new string[] { "AWD", "FWD", "4WD", "RWD" };
            comboBox.DataSource = driveTrains;
        }

    

        public void SaveProfile(ComboBox makeSelectionBox, ComboBox modelSelectionBox, ComboBox regYearSelectionBox, ComboBox engineSizeBox, ComboBox fuelTypeBox, ComboBox transmissionTypeBox, ComboBox drivetrainBox)
        {
            if (makeSelectionBox.Text != null & modelSelectionBox.Text != null & regYearSelectionBox.Text != null & engineSizeBox.Text != null & fuelTypeBox.Text != null & transmissionTypeBox.Text != null & drivetrainBox.Text != null)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    int makeID = 0;
                    int modelID = 0;
                    string fullname = ($"{regYearSelectionBox.Text} {makeSelectionBox.Text} {modelSelectionBox.Text} {engineSizeBox.Text}L {fuelTypeBox.Text} {transmissionTypeBox.Text} {drivetrainBox.Text}");
                    string profileInsert = "INSERT INTO cars (modelID, MakeID, regYear, fuelType, driveTrain, transmission, engineSize, fullName) values (@modelID, @makeID, @regYear,@fuelType,@driveTrain,@transmission,@engineSize,@fullName);";
                    string makesQuery = "SELECT MakeID from makes where makeName = @makeName;";
                    string modelQuery = "SELECT modelID from models where modelName = @modelName;";
                    using (SqlCommand makesSearch = new SqlCommand(makesQuery, connection))
                    {
                        makesSearch.Parameters.Add("@makeName", System.Data.SqlDbType.VarChar, 255).Value = makeSelectionBox.SelectedItem;
                        using (SqlDataReader myReader = makesSearch.ExecuteReader())
                        {
                            while (myReader.Read()) // loops to add all values read to a list.
                            {
                                makeID = myReader.GetInt32(0);
                            }
                        }
                    }
                    using (SqlCommand modelSearch = new SqlCommand(modelQuery, connection))
                    {
                        modelSearch.Parameters.Add("@modelName", System.Data.SqlDbType.VarChar, 255).Value = modelSelectionBox.SelectedItem;
                        using (SqlDataReader myReader = modelSearch.ExecuteReader())
                        {
                            while (myReader.Read()) // loops to add all values read to a list.
                            {
                                modelID = myReader.GetInt32(0);
                            }
                        }
                    }
                    using (SqlCommand profileInsertion = new SqlCommand(profileInsert, connection))
                    {
                        profileInsertion.Parameters.Add("@makeID", System.Data.SqlDbType.VarChar, 255).Value = makeID;
                        profileInsertion.Parameters.Add("@modelID", System.Data.SqlDbType.VarChar, 255).Value = modelID;
                        profileInsertion.Parameters.Add("@regYear", System.Data.SqlDbType.VarChar, 255).Value = regYearSelectionBox.Text;
                        profileInsertion.Parameters.Add("@fuelType", System.Data.SqlDbType.VarChar, 255).Value = fuelTypeBox.Text;
                        profileInsertion.Parameters.Add("@engineSize", System.Data.SqlDbType.VarChar, 255).Value = engineSizeBox.Text;
                        profileInsertion.Parameters.Add("@transmission", System.Data.SqlDbType.VarChar, 255).Value = transmissionTypeBox.Text;
                        profileInsertion.Parameters.Add("@driveTrain", System.Data.SqlDbType.VarChar, 255).Value = drivetrainBox.Text;
                        profileInsertion.Parameters.Add("@fullName", System.Data.SqlDbType.VarChar, 255).Value = fullname;
                        using (SqlDataReader myReader = profileInsertion.ExecuteReader()) ;
                    }
                }
                profileAdded newProfile = new profileAdded();
                newProfile.ShowDialog();
            }
            else
            {
                failedProfile profileFail = new failedProfile();
                profileFail.ShowDialog();
            }
        }
    }
}


