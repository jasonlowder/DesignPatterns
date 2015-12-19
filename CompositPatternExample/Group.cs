using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositPatternExample
{
    class Group : Party
    {
        public string Name { get; set; }
        //public List<Person> Members { get; set; }
        public List<Party> Members { get; set; }

        public Group()
        {
            //Members = new List<Person>();
            Members = new List<Party>();
        }

        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }
                return totalGold;
            }
            set
            {
                int eachSplit = value / Members.Count;
                int leftOver = value % Members.Count;

                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}
