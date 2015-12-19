using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.GumballExample.States
{
    class SoldState : State
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
		    Console.WriteLine("Please wait, we're already giving you a gumball");
	    }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
	    }

        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
	    }

        public void dispense()
        {
		    gumballMachine.releaseBall();
		    if (gumballMachine.Count > 0) {
                gumballMachine.State = new NoQuarterState(gumballMachine);
		    } else {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.State = new SoldOutState(gumballMachine);
		    }
	    }

        public override string ToString()
        {
            return "dispensing a gumball";
        }
    }
}
