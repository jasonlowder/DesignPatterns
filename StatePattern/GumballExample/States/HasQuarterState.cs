using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.GumballExample.States
{
    class HasQuarterState : State
    {
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.State = new NoQuarterState(gumballMachine);
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.State = new SoldState(gumballMachine);
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
