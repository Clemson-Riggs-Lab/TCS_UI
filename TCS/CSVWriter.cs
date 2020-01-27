using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

public class CsvWriter
{

    private List<string[]> rowData = new List<string[]>();
    private string filepath;

    // Use this for initialization
    public CsvWriter()
    {
        SetUp();
        filepath = Path.Combine( 
                                Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
                                "TimeOfCuePresenting" + DateTime.Now.ToString("MM-dd-yy-H-mm")+ ".csv"
                               );


    } 

    void SetUp()
    {
        // Creating First row of titles manually..
        string[] rowDataTemp = new string[17];
        rowDataTemp[0] = "Time of cue start";
        rowDataTemp[1] = "Time of cue end";
        rowDataTemp[2] = "New Screen Number";
        rowDataTemp[3] = "Cue Number For Input";
        rowDataTemp[4] = "Type Of Change";
        rowDataTemp[5] = "Starting Gain";
        rowDataTemp[6] = "Starting Frequency";
        rowDataTemp[7] = "Ending Gain";
        rowDataTemp[8] = "Ending Frequency";
        rowDataTemp[9] = "Starting Tactor Location";
        rowDataTemp[10] = "Ending Tactor Location";
        rowDataTemp[11] = "Starting ISI";
        rowDataTemp[12] = "Ending ISI";
        rowDataTemp[13] = "Starting Pulse Duration";
        rowDataTemp[14] = "Ending Pulse Duration";
        rowDataTemp[15] = "Start Change After Pulse Number";
        rowDataTemp[16] = "End Change After Pulse Number";
        rowData.Add(rowDataTemp);
    }
    public void AddEvent(string StartTime, string EndTime, Cue CurrentCue)
    {
        string[] rowDataTemp = new string[17];
        rowDataTemp[0] = StartTime;
        rowDataTemp[1] = EndTime;
        rowDataTemp[2] =  CurrentCue.NewScreenNumber.ToString();
        rowDataTemp[3] =  CurrentCue.CueNumberForInput.ToString();
        rowDataTemp[4] =  CurrentCue.TypeoOfChange;
        rowDataTemp[5] =  CurrentCue.StartingGain.ToString();
        rowDataTemp[6] =  CurrentCue.StartingFrequency.ToString(); 
        rowDataTemp[7] =  CurrentCue.EndingGain.ToString();      
        rowDataTemp[8] =  CurrentCue.EndingFrequency.ToString();
        rowDataTemp[9] =  CurrentCue.StartingTactorLocation.ToString();
        rowDataTemp[10] = CurrentCue.EndingTactorLocation.ToString();
        rowDataTemp[11] = CurrentCue.StartingISI.ToString();
        rowDataTemp[12] = CurrentCue.EndingISI.ToString();
        rowDataTemp[13] = CurrentCue.StartingPulseDuration.ToString();
        rowDataTemp[14] = CurrentCue.EndingPulseDuration.ToString();
        rowDataTemp[15] = CurrentCue.StartChangeAfterPulseNumber.ToString();
        rowDataTemp[16] = CurrentCue.EndChangeAfterPulseNumber.ToString();
        rowData.Add(rowDataTemp);
        Save();
    }

    public void Save()
    {

        string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        StreamWriter outStream = System.IO.File.CreateText(filepath);
        outStream.WriteLine(sb);
        outStream.Close();
    }


}