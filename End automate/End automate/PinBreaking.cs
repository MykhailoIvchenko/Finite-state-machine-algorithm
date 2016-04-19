using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace End_automate
{
    enum StateType
    {
        Initial = 0,
        FirstNumberBroken = 1,
        SecondNumberBroken = 2,
        ThirdNumberBroken = 3,
        PinBroken = 4
    }
    class PinBreaking
    {
        private int [] pin;
        public PinBreaking (int [] pinForBreaking)
	    {
            pin = pinForBreaking;
	    }
        StateType currentState;
        public void InitializeBreaking()
        {
            currentState = StateType.Initial;
            Console.WriteLine("Try to break in the pin. Enter the first number and press Enter button:");
        }
        public void CheckNumbers()
        {
            while ((int) currentState != 4)
            {
                int? checker = null;
                try
                {
                    checker = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("You have entered something wrong. Try again");
                    Thread.Sleep(1000);
                    Console.Clear();
                    InitializeBreaking();
                    continue;                   
                }
                    
                
                if ((int)currentState == 0 && checker == pin[0])
                {
                    OneNumberIsRight();
                    continue;
                }
                if ((int)currentState == 1 && checker == pin[1])
                {
                    TwoNumbersAreRight();
                    continue;
                }
                if ((int)currentState == 2 && checker == pin[2])
                {
                    ThreeNumbersAreRight();
                    continue;
                }
                if ((int)currentState == 3 && checker == pin[3])
                {
                    PinIsBrokenIn();
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Try again from the beginning");
                    Thread.Sleep(1500);
                    Console.Clear();
                    InitializeBreaking();
                    continue;
                }
            }
        }
        private void OneNumberIsRight()
        {
            currentState = StateType.FirstNumberBroken;
            Console.WriteLine("You have broken in first number. Enter the second number:");
        }
        private void TwoNumbersAreRight()
        {
            currentState = StateType.SecondNumberBroken;
            Console.WriteLine("You have broken in second number. Enter the third number:");
        }
        private void ThreeNumbersAreRight()
        {
            currentState = StateType.ThirdNumberBroken;
            Console.WriteLine("You have broken in first number. Enter the second number:");
        }
        private void PinIsBrokenIn()
        {
            currentState = StateType.PinBroken;
            Console.WriteLine("You have broken in the pin. Congratulations!");
        }
    }
}
