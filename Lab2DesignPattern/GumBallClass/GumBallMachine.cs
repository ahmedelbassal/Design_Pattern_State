using Lab2DesignPattern.Interfaces;
using Lab2DesignPattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DesignPattern.GumBallClass
{
    class GumBallMachine
    {
        IState _State;
        public int count = 0;

        public GumBallMachine(int numberGumBalls)
        {
            count = numberGumBalls;

            if (numberGumBalls > 0)
            {
                _State = new NoQuarter(this);
            }
            else
            {
                _State = new SoldOut(this);
            }
        }

        public void ReleaseBall()
        {
            Console.WriteLine("GumBall comes rolling out a lot........");

            if (count != 0)
            {
                count--;
            }
        }

        public void SetState(IState newState)
        {
            _State = newState;
        }


        public void PerformTurnCrank() => _State.TurnCrank();
        public void PerformInsertQuarter() => _State.InsertQuarter();
        public void PerformEjectQuarter() => _State.EjectQuarter();
        public void PerformDispense() => _State.Dispense();

        public void PerformShowState() => _State.ShowState();

    }
}
