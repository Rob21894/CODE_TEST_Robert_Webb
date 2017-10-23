using System.Collections.Generic;

namespace CODE_TEST_RobertWebb
{
    public class StringMatches
    {
        public List<int> SubtextMatches(string input, string subtext)
        {
            var inputLowercaseConversion = input.ToLower(); // only have to match lower case with the subtext
            var subtextLowercaseConversion = subtext.ToLower();

            List<int> indexes = new List<int>(); // initialize list to store index matches

            string temp = inputLowercaseConversion;
            int matchIndex = 0;
            int indexTemp = 1;
            while (temp.Length > subtextLowercaseConversion.Length) // check by length to avoid out of range exception
            {
                string check = "";
                for (int i = 0; i < subtextLowercaseConversion.Length; i++)
                {
                    if (char.IsLetter(temp[i]))
                    {
                        check += temp[i]; // add characters to string
                        matchIndex = indexTemp;
                    }
                    else
                    {
                        break; // exit out if not a letter
                    }
                }
                if (check == subtextLowercaseConversion) // check the stored characters match the subtext
                {
                    indexes.Add(matchIndex); // add the first index is true
                }
                temp = temp.Remove(0, 1); // remove 1 character
                indexTemp++; // increase index by 1 (to keep track of the removed characters)

            }
            return indexes;
        }
    }
}