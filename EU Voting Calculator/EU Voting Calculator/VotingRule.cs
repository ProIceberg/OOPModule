using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Voting_Calculator
{
    public class VotingRule
    {
        Loader load = new Loader();

        public void Vote()
        {
            int vote;

            for (int i=0; i< load.countryList.Count; i++)
            {
                vote = load.countryList[i].getVote();

                if (vote == 0)
                {

                }
                if (vote == 1)
                {

                }
                if (vote == 2)
                {

                }
            }
        }
}
}

