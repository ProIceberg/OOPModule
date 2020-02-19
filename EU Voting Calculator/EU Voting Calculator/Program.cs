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
            VotingCount vote = new VotingCount();
            vote.PassRules("Simple");

            Loader loader = new Loader();

            for (int i = 0; i < loader.countryList.Count; i++)
            {
                loader.countryList[i].output();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Form1(ref loader));
=======
            Application.Run(new Form1());

            
           
>>>>>>> 04f70acc4aaedf3bf8398d9acba982be2f18544b
        }

      
    }
}
