using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Giant IE6 Monster and gained {0} gold", goldForKill);

            var joe = new Person { Name = "Joe" };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian" };
            var oldBob = new Person { Name = "Old Bob" };
            var newBob = new Person { Name = "New Bob" };
            var bobs = new Group { Members = { oldBob, newBob } };
            var developers = new Group { Name = "Developers", Members = { joe, jake, emily, bobs } };
            
            ////var individuals = new List<Person> { sophia, brian };
            ////var groups = new List<Group> { developers };
            //var parties = new List<Party> { developers, sophia, brian };

            ////var totalToSplitBy = individuals.Count + groups.Count;
            //var totalToSplitBy = parties.Count;

            //var amountForEach = goldForKill / totalToSplitBy;
            //var leftOver = goldForKill % totalToSplitBy;

            ////foreach (var individual in individuals)
            ////{
            ////    individual.Gold += amountForEach + leftOver;
            ////    leftOver = 0;
            ////    individual.Stats();
            ////}

            ////foreach (var group in groups)
            ////{
            ////    var amountForEachGroupMember = amountForEach / group.Members.Count;
            ////    var leftOverForGroup = amountForEach % group.Members.Count;
            ////    foreach (var member in group.Members)
            ////    {
            ////        member.Gold += amountForEachGroupMember + leftOverForGroup;
            ////        leftOverForGroup = 0;
            ////        member.Stats();
            ////    }
            ////}

            //foreach (var partyMember in parties)
            //{
            //    partyMember.Gold += amountForEach + leftOver;
            //    leftOver = 0;
            //    partyMember.Stats();
            //}

            var parties = new Group { Members = { developers, sophia, brian } };

            parties.Gold += goldForKill;
            parties.Stats();

            Console.ReadKey();
        }
    }
}
