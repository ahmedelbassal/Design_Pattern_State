using Lab2DesignPattern.GumBallClass;
using Lab2DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DesignPattern.States
{
    class HasQuarter : IState
    {

        GumBallMachine _gumBall;

        public HasQuarter(GumBallMachine gumBall)
        {
            _gumBall = gumBall;
        }


        public void Dispense()
        {
            Console.WriteLine("Dispense when HasQuarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Eject Successfully (HasQuarter State func)");

            // change state to noQuarter
            _gumBall.SetState(new NoQuarter(_gumBall));
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Insert Twince (HasQuarter State func)");
        }

        public void ShowState()
        {
            Console.WriteLine("State : HasQuarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turn Successfully ( Has Quarter func)");

            // change state to sold
            _gumBall.SetState(new Sold(_gumBall));
            Dispense();
        }
    }
}
