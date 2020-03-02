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
        Console.WriteLine(filepath);
    } 

    void SetUp()
    {
        Console.WriteLine("set up correctly");
        // Creating First row of titles manually..
        string[] rowDataTemp = new string[19];
        rowDataTemp[0] = "Trial";
        rowDataTemp[1] = "Time of cue start";
        rowDataTemp[2] = "Time of cue end";
        rowDataTemp[3] = "Score";
        rowDataTemp[4] = "New Screen Number";
        rowDataTemp[5] = "Cue Number For Input";
        rowDataTemp[6] = "Type Of Change";
        rowDataTemp[7] = "Starting Gain";
        rowDataTemp[8] = "Starting Frequency";
        rowDataTemp[9] = "Ending Gain";
        rowDataTemp[10] = "Ending Frequency";
        rowDataTemp[11] = "Starting Tactor Location";
        rowDataTemp[12] = "Ending Tactor Location";
        rowDataTemp[13] = "Starting ISI";
        rowDataTemp[14] = "Ending ISI";
        rowDataTemp[15] = "Starting Pulse Duration";
        rowDataTemp[16] = "Ending Pulse Duration";
        rowDataTemp[17] = "Start Change After Pulse Number";
        rowDataTemp[18] = "End Change After Pulse Number";
        rowData.Add(rowDataTemp);
    }
    public void AddEvent(int Trial, string Response, string StartTime, string EndTime, Cue CurrentCue)
    {
        string[] rowDataTemp = new string[19];
        rowDataTemp[0] = Trial.ToString();
        rowDataTemp[1] = StartTime;
        rowDataTemp[2] = EndTime;
        rowDataTemp[3] = Response;
        rowDataTemp[4] =  CurrentCue.NewScreenNumber.ToString();
        rowDataTemp[5] =  CurrentCue.CueNumberForInput.ToString();
        rowDataTemp[6] =  CurrentCue.TypeoOfChange;
        rowDataTemp[7] =  CurrentCue.StartingGain.ToString();
        rowDataTemp[8] =  CurrentCue.StartingFrequency.ToString(); 
        rowDataTemp[9] =  CurrentCue.EndingGain.ToString();      
        rowDataTemp[10] =  CurrentCue.EndingFrequency.ToString();
        rowDataTemp[11] =  CurrentCue.StartingTactorLocation.ToString();
        rowDataTemp[12] = CurrentCue.EndingTactorLocation.ToString();
        rowDataTemp[13] = CurrentCue.StartingISI.ToString();
        rowDataTemp[14] = CurrentCue.EndingISI.ToString();
        rowDataTemp[15] = CurrentCue.StartingPulseDuration.ToString();
        rowDataTemp[16] = CurrentCue.EndingPulseDuration.ToString();
        rowDataTemp[17] = CurrentCue.StartChangeAfterPulseNumber.ToString();
        rowDataTemp[18] = CurrentCue.EndChangeAfterPulseNumber.ToString();
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