using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Manmeet Singh
 * Date:8/17/2017
 * StudentID:300932996
 * Description:The Pick the card game
 * Version:0.1
 */

namespace COMP123_S2017_FinalExam_300932996
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
