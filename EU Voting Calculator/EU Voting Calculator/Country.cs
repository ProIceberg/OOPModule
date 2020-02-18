using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_Voting_Calculator
{
    public class Country
    {
        //Declares the member variables of the country
        public string flag;
        public string name;
        public float population;
        public int vote;

        //Method used to get the state of the vote
        public int getVote()
        {
            return vote;
        }
        //Method used to set the state of the vote
        public void setVote(int newVote)
        {
            vote = newVote;
        }

        //Constructor for the country, takes a string containing the information for the country
        public Country(string data)
        {
            //Initializes two variables for later string splitting
            int x = -1;
            int y = -1;

            //For loop to iterate through the string and find the commas(these seperate data pieces)
            for (int i = 0; i < data.Length; i++)
            {
                //Checks if the character at index i is a comma
                if (data[i] == ',')
                {
                    //Checks if the first comma has been found. If not sets it to the index of the comma
                    if (x == -1)
                        x = i;
                    //If the first comma has been found, changes the second variable instead
                    else
                        y = i;
                }

            }
            //Splits the string into three substrings using the indexes of the commas
            name = data.Substring(0, x);
            flag = data.Substring(x + 1, y - (x + 1));
            //Gets the substring for the population, before converting to a float
            population = float.Parse(data.Substring(y + 1, data.Length - (y + 1)), System.Globalization.CultureInfo.InvariantCulture);

        }
        //Method to print to console the data. Used for debugging
        public void output()
        {
            Console.WriteLine($"Name: {name}, Flag: {flag}, Population: {population}");
        }
    }
}

//This is the blueprint for what a country is in the context of the program