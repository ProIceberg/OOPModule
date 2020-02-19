using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU_Voting_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //This creates a loader object that loads all the country data and creates country objects
            Loader loadTest = new Loader();

            for(int i = 0; i < loadTest.countryList.Count; i++)
            {
                loadTest.countryList[i].output();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
