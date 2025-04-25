using System;
using System.Windows.Forms;

namespace ConvStore
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //DBHelper.TestConnection(); //remove once connection is confirmed
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
