using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace TCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdvancedActionsForm());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.Run(new TCSForm());
            }

            static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
            {
                MessageBox.Show(e.Exception.Message, "Unhandled Thread Exception");
                // here you can log the exception ...
            }

            static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
            {
                MessageBox.Show((e.ExceptionObject as Exception).Message, "Unhandled UI Exception");
                // here you can log the exception ...
            }

        
    }
}
