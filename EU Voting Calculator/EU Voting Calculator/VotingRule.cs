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


        public void PassRules(string RuleType)
        {


            if (RuleType == "Qualified")
            {
                string info = "Minimum “Yes” required for adoption: (55%)";

            }
            if (RuleType == "Reinforced")
            {
                string info = "Minimum “Yes” required for adoption: (72%)";
            }
            if (RuleType == "Simple")
            {
                string info = "Minimum “Yes” required for adoption: (50%)";
            }
            if (RuleType == "Unanimity")
            {
                string info = "Minimum “Yes” required for adoption: (100%)";

            }

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
        public void YesVoteTotal()
        {
            //return yes;
        }
        public void NoVoteTotal()
        {
            //return no;
        }
        public void AbstainVoteTotal()
        {
            //return Abstain;
        }
    }
}

