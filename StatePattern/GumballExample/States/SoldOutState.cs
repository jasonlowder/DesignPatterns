using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.GumballExample.States
{
    class SoldOutState : State
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
		    Console.WriteLine("You can't insert a quarter, the machine is sold out");
	    }

        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
	    }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
	    }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
	    }

        public override string ToString()
        {
            return "sold out";
        }
    }
}
