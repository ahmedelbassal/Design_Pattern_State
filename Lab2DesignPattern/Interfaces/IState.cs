using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DesignPattern.Interfaces
{
    interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();

        void ShowState();
    }
}
