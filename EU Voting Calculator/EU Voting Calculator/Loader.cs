using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Voting_Calculator
{
    public class Loader
    {
        //List of all the countries
        public List<Country> countryList = new List<Country>();

        public Loader()
        {
            //Loads the country data into an array where each string is the info for one country
            string[] lines = System.IO.File.ReadAllLines("country list.txt");

            //Iterates through each line in the array and makes a new country before adding it to the country list
            for(int i = 0; i<lines.Length; i++)
            {
                //Creates the new country to be aded to the list, with the line from the file as a parameter
                Country newCountry = new Country(lines[i]);
                //Adds the newly created country to the list
                countryList.Add(newCountry);
            }
        }
    }
}

//This loads in the country data from file and creates a list of objects for each one.