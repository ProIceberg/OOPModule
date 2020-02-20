using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Voting_Calculator
{
    public class VotingCount
    {
        int vote;
        int yes = 0;
        int no = 0;
        int abstain = 0;
        Loader load = new Loader();


        public string PassRules(string RuleType)
        {
            string info;
            var percentage = 0.27;
            string Passed = "Rejected";
            
            
            if (RuleType == "Qualified")
            {
                info = "Minimum “Yes” required for adoption: (55%)";
                if (yes >= (percentage*55))
                {
                    Passed = "Approved";
                    return Passed;

                }
                else
                {
                    Passed = "Rejected";             
                    return Passed;
                }

            }
            if (RuleType == "Reinforced")
            {
                info = "Minimum “Yes” required for adoption: (72%)";
                if (yes >= (percentage*72))
                {
                    Passed = "Approved";
                    return Passed;

                }
                else
                {
                    Passed = "Rejected";
                    return Passed;
                }
            }
            if (RuleType == "Simple")
            {
                info = "Minimum “Yes” required for adoption: (50%)";
                if (yes >= (percentage*50))
                {
                    Passed = "Approved";
                    return Passed;
                }
                else
                {
                    Passed = "Rejected";
                    return Passed;
                }
            }
            if (RuleType == "Unanimity")
            {
                info = "Minimum “Yes” required for adoption: (100%)";
                if (yes >= (percentage*100))
                {
                    Passed = "Approved";
                    return Passed;
                }
                else
                {
                    Passed = "Rejected";
                    return Passed;
                }
            }
            return "Rejected";
        }

        public void Vote()
        {
            vote = 0;
            yes = 0;
            no = 0;
            abstain = 0;

            for (int i=0; i< load.countryList.Count; i++)
            {
                vote = load.countryList[i].getVote();

                // Vote = Yes
                if (vote == 0)
                {
                    yes++;

                }
                // Vote = No
                if (vote == 1)
                {
                    no++;
                }
                // Vote = Abstain
                if (vote == 2)
                {
                    abstain++;
                }
            }
       


        }
 
    }
}

