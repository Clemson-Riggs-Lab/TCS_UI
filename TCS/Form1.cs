using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;





namespace TCS
{
    public partial class TCSUIForm : Form
    {
        private int ConnectedDeviceID = -1;
        public string ComPort = "";
        List<Cue> cuesList = null;
        int NumberOfCues;
        CsvWriter csvWriter = new CsvWriter();
        private bool fileloaded;

        string[] args = Environment.GetCommandLineArgs();
        private System.Windows.Forms.Timer timer1;
        bool timed = false;
        DateTime simStartTime;

        public TCSUIForm()
        {
            
            InitializeComponent();
          //  selectCueNumericUpDown.Enabled = false;
          //  playCueButton.Enabled = false;
            //To initialize the TDKInterface we need to call InitializeTI before we use any
            //of its functionality
            CheckTDKErrors(Tdk.TdkInterface.InitializeTI());


            if (!String.IsNullOrEmpty(GetArg("-inputFilePath")))
            {
                if (bool.TryParse(GetArg("-simTimed"), out bool b))
                {
                    timed = b;
                }
                if (timed)
                {
                    if (DateTime.TryParse(GetArg("-simStartTime"), out DateTime s))
                    {
                        simStartTime = s;
                    }
                    else
                    {
                        simStartTime = DateTime.Now;
                    }
                }


                if (!String.IsNullOrEmpty(GetArg("-inputFilePath")))
                {
                    ReadFile(GetArg("-inputFilePath"), timed);
                }

                //if (timed)
                //{
                //    InitTimer();
                  //  selectCueNumericUpDown.Enabled = false;
                  //  playCueButton.Enabled = false;
                //}

            }


        }

        private void ReadFile(string file, bool timed = false)
        {
            try
            {
                CSVReader reader = new CSVReader();
                cuesList = reader.Load(file, timed, simStartTime);
                NumberOfCues = reader.NumRows();
                //CurrentCueIndex = 0;
                string text = File.ReadAllText(file);
                fileloaded = true;
                BrowseFileButton.Enabled = false;
            }
            catch (IOException)
            {
            }
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            //Discovers all serial tactor devices and returns the amount found
            int num_tactors = Tdk.TdkInterface.Discover((int)Tdk.TdkDefines.DeviceTypes.Serial);
            if (num_tactors > 0)
            {
                //populate combo box with discovered names
                for (int i = 0; i < num_tactors; i++)
                {
                    //Gets the discovered device name at the index i
                    System.IntPtr discoveredNamePTR = Tdk.TdkInterface.GetDiscoveredDeviceName(i);
                    if (discoveredNamePTR != null)
                    {
                        this.ComPort = Marshal.PtrToStringAnsi(discoveredNamePTR);
                        DiscoverButton.Enabled = false;
                        ConnectButton.Enabled = true;
                    }
                }
                
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connect connects to the tactor controller via serial with the given name
                //we should be hooking up a response callback but for simplicity of the 
                //tutorial we wont be. Reference the ResponseCallback tutorial for more information
                int tactor_device_ID = Tdk.TdkInterface.Connect(this.ComPort,
                                                   (int)Tdk.TdkDefines.DeviceTypes.Serial,
                                                    System.IntPtr.Zero);
                if (tactor_device_ID >= 0)
                {
                    ConnectedDeviceID = tactor_device_ID;
                    DiscoverButton.Enabled = false;
                    ConnectButton.Enabled = false;

                    if (fileloaded == false)
                    {
                        ConnectButton.Enabled = false;
                        BrowseFileButton.Enabled = true;
                   }
                    else
                    {
                        BrowseFileButton.Enabled = false;
                    }

                }
            }
            catch
            {
                DiscoverButton_Click(new object(), new EventArgs());
            }
        }

        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                ReadFile(file);
                BrowseFileButton.Enabled = false;
                BeginButton.Enabled = true;
            }

        }  

        private void BeginButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var Form2 = new Form2(ConnectedDeviceID, cuesList, NumberOfCues);
            Form2.Show();
        }

       private static string GetArg(string name)
        {
            var args = System.Environment.GetCommandLineArgs();
            
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == name && args.Length > i + 1)
                {
                    return args[i + 1];
                }
            }
            return null;
        }

        private void CheckTDKErrors(int ret)
        {
            //if a tdk method returns less then zero then we should display the last error
            //in the tdk interface
            if (ret < 0)
            {
                //the GetLastEAIErrorString returns a string that represents the last error code
                //recorded in the tdk interface.
                Console.WriteLine(Tdk.TdkDefines.GetLastEAIErrorString());
            }
        }

    }

}



