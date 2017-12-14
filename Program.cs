using System;
using System.Windows.Forms;

namespace pKami.SimpleTimer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new System.UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimpleTimerForm());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = (Exception)e.ExceptionObject;
            ShowException(exception);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception exception = (Exception)e.Exception;
            ShowException(exception);
        }

        private static void ShowException(Exception exception)
        {
            if (exception != null)
            {
                MessageBox.Show(exception.Message + " \r\n" + exception.StackTrace, "Unhandled Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Unexpected error!", "Unexpected error without additional info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
