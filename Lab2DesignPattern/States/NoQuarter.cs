using Lab2DesignPattern.GumBallClass;
using Lab2DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DesignPattern.States
{
    class NoQuarter : IState
    {

        GumBallMachine _gumBall;

        public NoQuarter(GumBallMachine gumBall)
        {
            _gumBall = gumBall;
        }



        public void Dispense()
        {
            Console.WriteLine("Dispense when No Quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Eject When NoQuarter");
        }

        public void InsertQuarter()
        {
            // here change state to has quarter
            _gumBall.SetState(new HasQuarter(_gumBall));

            Console.WriteLine("Insert Successfully (NoQuarter State func)");
        }

        public void ShowState()
        {
            Console.WriteLine("State : NoQuarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turn when No Quarter");
        }
    }
}
