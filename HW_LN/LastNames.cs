using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNames
{
    class LastNames
    {
        private List<string> lname;

        public LastNames(List<string> initialList)
        {
            lname = new List<string>();
            foreach (string a in initialList)
            {
                lname.Add(a);
            }
            lname.Sort();
        }

        private int getLastNameIndex(string searchLN)
        {
            int index = -1;
            for (int i = 0; i < lname.Count; ++i)
            {
                if (lname[i].Equals(searchLN))
                {
                    index = i + 1;
                    break;
                }

            }
            return index;
        }

        private void addLastName(string addLN)
        {
            lname.Add(addLN);
            lname.Sort();
        }

        static string Capitalize(string s)
        {
            s = s[0].ToString().ToUpper() + s.Substring(1).ToLower();
            return s;
        }

        public string ProcessLastName(string lastName)
        {
            lastName = Capitalize(lastName);
            int result = getLastNameIndex(lastName);
            if (result < 0)
            {
                addLastName(lastName);
                result = getLastNameIndex(lastName);
            }

            string ret = $"Querried last name {lastName} has index = {result} \n";
            ret += string.Join("\n", lname);
            return ret;

        }
    }
}