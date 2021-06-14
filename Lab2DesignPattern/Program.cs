using Lab2DesignPattern.GumBallClass;
using Lab2DesignPattern.States;
using System;

namespace Lab2DesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            GumBallMachine gumBall=new(2);

            Console.WriteLine("Create GumBall with 2 balls");
            gumBall.PerformShowState();

            gumBall.PerformEjectQuarter();

            gumBall.ReleaseBall();
            gumBall.ReleaseBall();
            gumBall.PerformInsertQuarter();

            gumBall.PerformShowState();

            Console.WriteLine("\n");
            Console.WriteLine("Change State to sold");

            gumBall.SetState(new Sold(gumBall));
            gumBall.PerformDispense();
        }
    }
}
