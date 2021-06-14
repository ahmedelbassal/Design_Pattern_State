using Lab2DesignPattern.GumBallClass;
using Lab2DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DesignPattern.States
{
    class SoldOut : IState
    {
        GumBallMachine _gumBall;

        public SoldOut(GumBallMachine gumBall)
        {
            _gumBall = gumBall;
        }


        public void Dispense()
        {
            Console.WriteLine("Dispense when Sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Eject When SoldOut");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Insert when Sold out (Soldout State func)");
        }

        public void ShowState()
        {
            Console.WriteLine("State : SoldOut");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turn when Sold out");
        }
    }
}
