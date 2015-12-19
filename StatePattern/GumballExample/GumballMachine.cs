using StatePattern.GumballExample.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.GumballExample
{
    class GumballMachine
    {
        public State State { get; set; }
        public int Count { get; set; }

        public GumballMachine(int numberOfGumballs)
        {
            Count = numberOfGumballs;
            if (Count > 0)
                State = new NoQuarterState(this);
            else
                State = new SoldOutState(this);
        }

        public void insertQuarter()
        {
            State.insertQuarter();
        }

        public void ejectQuarter()
        {
            State.ejectQuarter();
        }

        public void turnCrank()
        {
            State.turnCrank();
            State.dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count -= 1;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\n.Net-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + Count + " gumball");
            if (Count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + State + "\n");
            return result.ToString();
        }
    }
}
