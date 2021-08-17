using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.SehrSchwer
{
    public class ContactList
    {
        public static string[] AscOrder(string[] names, string sort)
        {
            if(names == null || names.Length == 0)
            {
                return Array.Empty<string>();
            }

            if(sort == "ASC")
            {
                List<string> lastnames = new List<string>();

                foreach (string name in names)
                {
                    string[] nameArray = name.Split(' ');

                    lastnames.Add(nameArray.Last());
                }

                lastnames.Sort();

                List<string> sortedasc = new List<string>();

                foreach (string lastname in lastnames)
                {
                    foreach (string name2 in names)
                    {
                        if (name2.Contains(lastname))
                        {
                            sortedasc.Add(name2);
                        }
                    }
                }

                return sortedasc.ToArray();
            }

            if (sort == "DESC")
            {
                List<string> lastnames = new List<string>();

                foreach (string name in names)
                {
                    string[] nameArray = name.Split(' ');

                    lastnames.Add(nameArray.Last());
                }

                lastnames.Sort((a, b) => b.CompareTo(a));

                List<string> sortedasc = new List<string>();

                foreach (string lastname in lastnames)
                {
                    foreach (string name2 in names)
                    {
                        if (name2.Contains(lastname))
                        {
                            sortedasc.Add(name2);
                        }
                    }
                }

                return sortedasc.ToArray();
            }

            return Array.Empty<string>();
        }
    }
}
