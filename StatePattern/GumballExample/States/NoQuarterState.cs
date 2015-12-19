using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.GumballExample.States
{
    class NoQuarterState : State
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.State = new HasQuarterState(gumballMachine);
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}
