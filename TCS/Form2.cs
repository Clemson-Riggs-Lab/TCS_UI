using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace TCS
{
    public partial class Form2 : Form
    {
        int current_trial_no = 1;
        List<Cue> cuesList = null;
        Cue currentCue = null;
        int NumberOfCues;
        int CurrentCueIndex = 0;
        CsvWriter csvWriter = new CsvWriter();
        bool played = false;

        public int ConnectedDeviceID;
        DateTime startTime;
        DateTime endTime;

        public Form2(int ConnectedDevice, List<Cue> cuesList, int NumberOfCues)
        {

            InitializeComponent();
            //Tdk.TdkInterface.InitializeTI();

            this.ConnectedDeviceID = ConnectedDevice;
            this.cuesList = cuesList;
            this.NumberOfCues = NumberOfCues;
            Console.WriteLine(NumberOfCues);
            Console.WriteLine(cuesList.Count);

            string data_concept = cuesList[0].Instructions;
            this.InstructionsTextbox.Text = "Please indicate what magnitude of the concept of " +
                data_concept + " that the vibration seems to represent by assigning a number estimating its " +
                data_concept + " relative to your subjective impression of the first vibration that you felt.";

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (cuesList != null && CurrentCueIndex < NumberOfCues-1)
            { // if there are cues left to read (excluding the last row)

                if (played==false)
                {
                    WarningsLabel.Text = "Please play the cue before proceeding.";
                }
                else if (ResponseTextbox.Text == "")
                {
                    WarningsLabel.Text = "Please enter a score";
                }
                else
                {
                    WarningsLabel.Text = "";

                    // save response into csv
                    int trial = current_trial_no;
                    string response = ResponseTextbox.Text;
                    csvWriter.AddEvent(trial, response, startTime.ToString("HH:mm:ss:ffff"), endTime.ToString("HH:mm:ss:ffff"), currentCue);

                    // set Trial1Score to first score 
                    if (current_trial_no==1)
                    {
                        Trial1Score.Text = "Trial 1 Score: " + response;
                    }

                    // increment tactor row 
                    CurrentCueIndex++;
                    current_trial_no++;

                    // update trial no.
                    TrialNumberLabel.Text = "Trial #: " + current_trial_no;
                    ResponseTextbox.Text = "";

                    Console.WriteLine(TrialNumberLabel.Text);
                    Console.WriteLine(CurrentCueIndex);
                    Console.WriteLine(ResponseTextbox.Text);

                    played = false;
                }
            }
            else if (cuesList != null && CurrentCueIndex == NumberOfCues-1)
            { // last cue

                if (played == false)
                {
                    WarningsLabel.Text = "Please play the cue before proceeding.";
                }
                else if (ResponseTextbox.Text == "")
                {
                    WarningsLabel.Text = "Please enter a score";
                }
                else
                {
                    WarningsLabel.Text = "";

                    // save response into csv
                    int trial = current_trial_no;
                    string response = ResponseTextbox.Text;
                    csvWriter.AddEvent(trial, response, startTime.ToString("HH:mm:ss:ffff"), endTime.ToString("HH:mm:ss:ffff"), currentCue);

                    //change screen to FormFinished
                    Console.WriteLine("cuesList is null or CurrentCueIndex < NumberOfCues");
                    this.Visible = false;
                    var FormFinished = new FormFinished(ConnectedDeviceID);
                    FormFinished.Show();
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

            //DEBUGGING
            Console.WriteLine(currentCue.TypeoOfChange);


            #region Variables

            played = true;
            WarningsLabel.Text = "";
            this.startTime = DateTime.Now;
            int cueIndex = CurrentCueIndex;
            this.currentCue = cuesList[cueIndex];

            int startChange = currentCue.StartChangeAfterPulseNumber;
            string typeOfChange = currentCue.TypeoOfChange;

            //tactors
            int tactor = currentCue.StartingTactorLocation;
            int tactor2 = currentCue.EndingTactorLocation;

            //motion tactors
            int firsttactor = currentCue.StartingTactorLocation;
            int secondtactor = currentCue.MiddleTactorLocation;
            int thirdtactor = currentCue.EndingTactorLocation;

            //parameters
            int frequency = currentCue.StartingFrequency;
            int pulseDuration = currentCue.StartingPulseDuration;
            int pulseDuration2 = currentCue.EndingPulseDuration;
            int gain = currentCue.StartingGain;

            int startPulseBreak = currentCue.StartingPulseDuration + currentCue.StartingISI;
            int endPulseBreak = currentCue.EndingPulseDuration + currentCue.EndingISI;
            int transitionPulses = currentCue.EndChangeAfterPulseNumber - currentCue.StartChangeAfterPulseNumber;
            float gainIncrement = 0;
            float freqIncrement = 0;
            if (transitionPulses != 0)
            {
                gainIncrement = (currentCue.EndingGain - currentCue.StartingGain) / (transitionPulses);
                freqIncrement = (currentCue.EndingFrequency - currentCue.StartingFrequency) / (transitionPulses);
            }

            #endregion Variables


            if (typeOfChange == "Temporal")
            {   //Temporal
                for (int i = 0; i < startChange; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
                for (int i = 0; i < 8 - startChange; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration2);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration2, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration2, 0);
                }
            }

            else if (typeOfChange == "Spatial")
            {   //Spatial
                for (int i = 0; i < startChange; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
                for (int i = 0; i < 8 - startChange; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor2, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor2, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor2, pulseDuration, 0);
                }
            }

            else if (typeOfChange == "Intensity")
            {   //Intensity
                for (int i = 0; i < startChange + 1; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);

                }
                for (int i = 0; i < transitionPulses; i++)
                {
                    gain = gain + Convert.ToInt32(gainIncrement);
                    frequency = frequency + Convert.ToInt32(freqIncrement);

                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
                // for (int i = 0; i < 8 - currentCue.EndChangeAfterPulseNumber - 1 - transitionPulses; i++)// testing only ( problem where intensity only presents 7 vibrations instead of 8)
                for (int i = 0; i < 8 - currentCue.EndChangeAfterPulseNumber - transitionPulses; i++)
                {

                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
            }

            else if (typeOfChange == "Int+Temp")
            {   //Intensity + Temporal

                for (int i = 0; i < startChange + 1; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
                for (int i = 0; i < transitionPulses; i++)
                {
                    gain = gain + Convert.ToInt32(gainIncrement);
                    frequency = frequency + Convert.ToInt32(freqIncrement);
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration2);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration2, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration2, 0);
                    //Debug.Log ("Gain: " + gain);
                }
                for (int i = 0; i < 8 - startChange - 1 - transitionPulses; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration2);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration2, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration2, 0);
                }
            }

            else if (typeOfChange == "Spat+Temp")
            { //Spatial + Temporal
                for (int i = 0; i < startChange; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);

                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
                for (int i = 0; i < 8 - startChange; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor2, frequency, pulseDuration2);
                    Tdk.TdkInterface.RampGain(0, tactor2, gain, gain, pulseDuration2, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor2, pulseDuration2, 0);
                }

            }

            else if (typeOfChange == "Int+Spat")
            {   //Intensity + Spatial
                for (int i = 0; i < startChange + 1; i++)
                {
                    if (i == startChange)
                    {
                        tactor = tactor2;
                    }
                    Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
                }
                for (int i = 0; i < transitionPulses; i++)
                {
                    gain = gain + Convert.ToInt32(gainIncrement);
                    frequency = frequency + Convert.ToInt32(freqIncrement);
                    Tdk.TdkInterface.ChangeFreq(0, tactor2, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor2, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor2, pulseDuration, 0);
                }
                for (int i = 0; i < 8 - startChange - 1 - transitionPulses; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, tactor2, frequency, pulseDuration);
                    Tdk.TdkInterface.RampGain(0, tactor2, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, tactor2, pulseDuration, 0);
                }
            }

            else if (typeOfChange == "Motion")
            { //Motion

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        //change freq of only the first one???
                        Tdk.TdkInterface.ChangeFreq(0, currentCue.StartingTactorLocation, frequency, pulseDuration);
                        Tdk.TdkInterface.RampGain(0, currentCue.StartingTactorLocation, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                        if (i == 0)
                            Tdk.TdkInterface.Pulse(0, firsttactor, pulseDuration, 0);
                        if (i == 1)
                            Tdk.TdkInterface.Pulse(0, secondtactor, pulseDuration, 0);
                        if (i == 2)
                            Tdk.TdkInterface.Pulse(0, thirdtactor, pulseDuration, 0);
                        toggleOn(0, currentCue.DelayWithin1);
                    }
                    toggleOn(0, currentCue.DelayBetween1);
                }
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Tdk.TdkInterface.ChangeFreq(0, currentCue.StartingTactorLocation, frequency, pulseDuration);
                        Tdk.TdkInterface.RampGain(0, currentCue.StartingTactorLocation, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                        if (i == 0)
                            Tdk.TdkInterface.Pulse(0, firsttactor, pulseDuration, 0);
                        if (i == 1)
                            Tdk.TdkInterface.Pulse(0, secondtactor, pulseDuration, 0);
                        if (i == 2)
                            Tdk.TdkInterface.Pulse(0, thirdtactor, pulseDuration, 0);
                        toggleOn(0, currentCue.DelayWithin2);
                    }
                    toggleOn(0, currentCue.DelayBetween2);
                }
            }

            else
            {
                string error = "\"" + typeOfChange + "\"" +
                    "is not a valid type of change. Was this a typo?";
                Console.WriteLine(error);
                WarningsLabel.Text = error;
            }

            this.endTime = DateTime.Now;
        }

        private void toggleOn(int id, int delay)
        {
            //tactorOn[id] = true;
            Thread.Sleep(delay);
            //tactorOn[id] = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        //public void InitTimer()
        //{
        //    timer1 = new System.Windows.Forms.Timer();
        //    timer1.Tick += new EventHandler(timer1_Tick);
        //    timer1.Interval = 50; // in miliseconds
        //    timer1.Start();
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (CurrentCueIndex < NumberOfCues)
        //    {
        //        if (DateTime.Now > cuesList[CurrentCueIndex].presentTime)
        //        {
        //            NextCueButton_Click(new object(), new EventArgs());
        //        }
        //        else
        //        {
        //            TimeSpan delta = cuesList[CurrentCueIndex].presentTime - DateTime.Now;
        //            //  DeltaTimeLable.Text = String.Format("{0:HH:mm:ss}", new DateTime(Math.Abs(delta.Ticks)));


        //        }
        //    }
        //}

    }
}
