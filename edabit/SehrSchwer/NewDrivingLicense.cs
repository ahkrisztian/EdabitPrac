using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit
{
    public static class NewDrivingLicense
    {
        //New Driving License
        //You have to get a new driver's license. You show up at the office at the same time as four other people. The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out with your new license?
        //Your input will be a string of your name me, an integer of the number of available agents, and a string of the other four names separated by spaces others.
        //Return the number of minutes it will take to get your license.
        //License("Eric", 2, "Adam Caroline Rebecca Frank") ➞ 40
        // As you are in the second group of people.
        //##persolut edabit

        public static string NewDrivincL(string name, int agents, string names)
        {
            int time = 20;

            List<string> NamesList = names.Split(' ').ToList();

            List<string> ListOfNames = NamesList.ToList();

            ListOfNames.Add(name);

            ListOfNames.Sort();

            List<List<string>> groups = new List<List<string>>();

            int NumberOfNames = ListOfNames.Count;

            for (int i = 0; i < NumberOfNames; i++)
            {
                if (ListOfNames.Count != 0)
                {
                    groups.Add(ListOfNames.GetRange(0, agents));
                    ListOfNames.RemoveRange(0, agents);

                    if (ListOfNames.Count < agents)
                    {
                        groups.Add(ListOfNames.GetRange(0, ListOfNames.Count()));
                        ListOfNames.RemoveRange(0, ListOfNames.Count());
                    }
                }
                else
                {
                    continue;
                }
            }

            int times = 1;

            foreach (List<string> s in groups)
            {
                if (s.Contains(name))
                {
                    times += groups.IndexOf(s);
                }

            }

            return $"{time * times}";
        }
    }
}
