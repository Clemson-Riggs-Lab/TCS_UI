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
                beginButton.Enabled = true;
            }

        }  

        //private void NextCueButton_Click(object sender, EventArgs e)
        //{
        //    if (cuesList != null && CurrentCueIndex < NumberOfCues)
        //    {
        //        PlayCue(CurrentCueIndex);
        //        CurrentCueIndex++;
        //    }
        //}

        //private void PlayCue(int cueIndex)
        //{
            
        //    DateTime startTime = DateTime.Now;
        //    Cue currentCue = cuesList[cueIndex];
        //    int startPulseBreak = currentCue.StartingPulseDuration + currentCue.StartingISI;
        //    int endPulseBreak = currentCue.EndingPulseDuration + currentCue.EndingISI;
        //    int transitionPulses = currentCue.EndChangeAfterPulseNumber - currentCue.StartChangeAfterPulseNumber;
        //    float gainIncrement = 0;
        //    float freqIncrement = 0;
        //    if (transitionPulses != 0)
        //    {
        //        gainIncrement = (currentCue.EndingGain - currentCue.StartingGain) / (transitionPulses);
        //        freqIncrement = (currentCue.EndingFrequency - currentCue.StartingFrequency) / (transitionPulses);
        //    }


        //    if (currentCue.TypeoOfChange == "Temporal")
        //    {   //Temporal
        //        for (int i = 0; i < currentCue.StartChangeAfterPulseNumber; i++)
        //        {                  
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //        }
        //        for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, endPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.EndingPulseDuration, 0);
        //        }
        //    }


        //    else if (currentCue.TypeoOfChange == "Spatial")
        //    {   //Spatial
        //        for (int i = 0; i < currentCue.StartChangeAfterPulseNumber; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            
        //        }
        //        for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            
        //        }
        //    }

        //    else if (currentCue.TypeoOfChange == "Intensity")
        //    {   //Intensity
        //        for (int i = 0; i < currentCue.StartChangeAfterPulseNumber + 1; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //            
        //        }
        //        for (int i = 0; i < transitionPulses; i++)
        //        {
        //            currentCue.StartingGain = currentCue.StartingGain + Convert.ToInt32(gainIncrement);
        //            currentCue.StartingFrequency = currentCue.StartingFrequency + Convert.ToInt32(freqIncrement);

        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //            
        //        }
        //        // for (int i = 0; i < 8 - currentCue.EndChangeAfterPulseNumber - 1 - transitionPulses; i++)// testing only ( problem where intensity only presents 7 vibrations instead of 8)
        //        for (int i = 0; i < 8 - currentCue.EndChangeAfterPulseNumber  - transitionPulses; i++)
        //        {

        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //            
        //        }
        //    }
        //    else if (currentCue.TypeoOfChange == "Int+Temp")
        //    {   //Intensity + Temporal

        //        for (int i = 0; i < currentCue.StartChangeAfterPulseNumber + 1; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //            
        //        }
        //        for (int i = 0; i < transitionPulses; i++)
        //        {
        //            currentCue.StartingGain = currentCue.StartingGain + Convert.ToInt32(gainIncrement);
        //            currentCue.StartingFrequency = currentCue.StartingFrequency + Convert.ToInt32(freqIncrement);
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, endPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.EndingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //            
        //        }
        //        for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber - 1 - transitionPulses; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, endPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.EndingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //           
        //        }
        //    }
        //    else if (currentCue.TypeoOfChange == "Spat+Temp")
        //    { //Spatial + Temporal
        //        for (int i = 0; i < currentCue.StartChangeAfterPulseNumber; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);

        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            
        //        }
        //        for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, endPulseBreak);
        //            Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.EndingPulseDuration, 0);
        //           
        //        }

        //    }
        //    else
        //    {   //Intensity + Spatial
        //        for (int i = 0; i < currentCue.StartChangeAfterPulseNumber + 1; i++)
        //        {
        //            if (i == currentCue.StartChangeAfterPulseNumber)
        //            {
        //                 currentCue.StartingTactorLocation = currentCue.EndingTactorLocation;
        //            }
        //            Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //            
        //        }
        //        for (int i = 0; i < transitionPulses; i++)
        //        {
        //            currentCue.StartingGain = currentCue.StartingGain + Convert.ToInt32(gainIncrement);
        //            currentCue.StartingFrequency = currentCue.StartingFrequency + Convert.ToInt32(freqIncrement);
        //            Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //           
        //        }
        //        for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber - 1 - transitionPulses; i++)
        //        {
        //            Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
        //            Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
        //            toggleOn(0, startPulseBreak);
        //            Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.StartingPulseDuration, 0);
        //            //Debug.Log ("Gain: " + currentCue.StartingGain);
        //          
        //        }
        //    }
        //    DateTime endTime = DateTime.Now;
        //    csvWriter.AddEvent(startTime.ToString("HH:mm:ss:ffff"), endTime.ToString("HH:mm:ss:ffff"), currentCue);
        //}


        //private void toggleOn(int id, int delay)
        //{
        //    //tactorOn[id] = true;
        //    Thread.Sleep(delay);
        //    //tactorOn[id] = false;
        //}


        //public void InitTimer()
        //{
        //    timer1 = new System.Windows.Forms.Timer();
        //    timer1.Tick += new EventHandler(timer1_Tick);
        //    timer1.Interval = 50; // in miliseconds
        //    timer1.Start();
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{ if (CurrentCueIndex < NumberOfCues )
        //    {
        //        if (DateTime.Now > cuesList[CurrentCueIndex].presentTime)
        //        {
        //            NextCueButton_Click(new object(), new EventArgs());
        //        }
        //        else
        //        {
        //            TimeSpan delta = cuesList[CurrentCueIndex].presentTime - DateTime.Now;
        //          //  DeltaTimeLable.Text = String.Format("{0:HH:mm:ss}", new DateTime(Math.Abs(delta.Ticks)));


        //        }
        //    }
        //}

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

        private void TCSUIForm_Load(object sender, EventArgs e)
        {

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

        private void outputCSVTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var Form2 = new Form2(ConnectedDeviceID, cuesList, NumberOfCues);
            Form2.Show();
        }

    }

}



