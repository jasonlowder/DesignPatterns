using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.GumballExample
{
    public class GumballExample
    {
        public void Run()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine.ToString());

            Console.ReadKey();
        }
    }
}
