using Lab2DesignPattern.GumBallClass;
using Lab2DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DesignPattern.States
{
    class Sold : IState
    {

        GumBallMachine _gumBall;

        public Sold(GumBallMachine gumBall)
        {
            _gumBall = gumBall;
        }


        public void Dispense()
        {
            Console.WriteLine("Dispense Successfully (Sold Function)");


           
            if (_gumBall.count > 0)
            {
                // decreate count by one
                _gumBall.count--;

                // if not change state to no quarter
                _gumBall.SetState(new NoQuarter(_gumBall));
            }
            else if (_gumBall.count == 0) { 

                Console.WriteLine("Dispense the last GumBall");

                // change state to soldout
                _gumBall.SetState(new SoldOut(_gumBall));
            }
            

        }

        public void EjectQuarter()
        {
            Console.WriteLine("Eject When Sold");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Insert when Sold (Sold State func)");
        }

        public void ShowState()
        {
            Console.WriteLine("State : Sold");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turn twice ( Sold State Func)");
        }
    }
}
