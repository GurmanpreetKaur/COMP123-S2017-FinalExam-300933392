using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Gurmanpreet Kaur
 * Date: 17 aug , 2017
 * StudentID: 300933392
 * Description: This is the main driver class for the progarm 
 * Version 0.1 - modified to show the SplashForm first 
 */

namespace COMP123_S2017_FinalExam_300933392
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
