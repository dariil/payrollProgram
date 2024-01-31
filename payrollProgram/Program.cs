using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formSignIn signIn;
            while (true)
            {
                signIn = new formSignIn();
                if(signIn.ShowDialog() == DialogResult.Yes)
                {
                    Application.Run(new payrollProgram());
                    continue;
                }
                else
                {
                    Application.Exit();
                    break;
                }
            }
        }
    }
}
