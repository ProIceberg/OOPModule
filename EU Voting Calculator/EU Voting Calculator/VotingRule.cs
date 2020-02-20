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
        public float yes;
        public float no;
        public float abstain;
        public string rule;

        Loader load;

<<<<<<< HEAD
        public VotingCount(ref Loader _load)
        {
            load = _load;
        }

        public string PassRules()
        {
            string info;
            var percentage = 0.27;
            string Passed;
            string RuleType = rule;
=======
        public string PassRules(string RuleType)
        {
            string info;
            var percentage = 0.27;
            string Passed = "Rejected";
            
>>>>>>> a0136547a0a6719c12eff0e2079fa987edb402c6
            
            if (RuleType == "Qualified Majority")
            {
                info = "Minimum “Yes” required for adoption: (55%)";
                if (yes >= (percentage*55))
                {
<<<<<<< HEAD
                    Passed = "Passed";
=======
                    Passed = "Approved";
>>>>>>> a0136547a0a6719c12eff0e2079fa987edb402c6
                    return Passed;

                }
                else
                {
                    Passed = "Rejected";             
                    return Passed;
                }

            }
            if (RuleType == "Reinforced Qualified Majority")
            {
                info = "Minimum “Yes” required for adoption: (72%)";
                if (yes >= (percentage*72))
                {
<<<<<<< HEAD
                    Passed = "Passed";
=======
                    Passed = "Approved";
>>>>>>> a0136547a0a6719c12eff0e2079fa987edb402c6
                    return Passed;

                }
                else
                {
                    Passed = "Rejected";
                    return Passed;
                }
            }
            if (RuleType == "Simple Majority")
            {
                info = "Minimum “Yes” required for adoption: (50%)";
                if (yes >= (percentage*50))
                {
<<<<<<< HEAD
                    Passed = "Passed";
=======
                    Passed = "Approved";
>>>>>>> a0136547a0a6719c12eff0e2079fa987edb402c6
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
<<<<<<< HEAD
                    Passed = "Passed";
=======
                    Passed = "Approved";
>>>>>>> a0136547a0a6719c12eff0e2079fa987edb402c6
                    return Passed;
                }
                else
                {
                    Passed = "Rejected";
                    return Passed;
                }
            }
<<<<<<< HEAD
            return "DEFAULT" ;
=======
            return "Rejected";
>>>>>>> a0136547a0a6719c12eff0e2079fa987edb402c6
        }

        public void Vote()
        {
            vote = 0;
            yes = 0;
            no = 0;
            abstain = 0;

            for (int i=0; i < load.countryList.Count; i++)
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

