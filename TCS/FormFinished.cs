using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TCS
{
    public partial class FormFinished : Form
    {
        public int ConnectedDeviceID;

        public FormFinished(int ConnectedDeviceID)
        {
            this.ConnectedDeviceID = ConnectedDeviceID;
            InitializeComponent();
        }

        private void FormFinished_Load(object sender, EventArgs e)
        {
            FinishedLabel.Text = "You are now finished! \n You may now exit this window";
        }

        private void TCS_FormClosed(object sender, FormClosedEventArgs e)
        {
            //closes up the connection to the tactor device with ConnectedBoardID
            CheckTDKErrors(Tdk.TdkInterface.Close(ConnectedDeviceID));
            //cleans up everyting associated witht the TActionManager. Unloads any TActions loaded
            CheckTDKErrors(Tdk.TdkInterface.ShutdownTI());
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
