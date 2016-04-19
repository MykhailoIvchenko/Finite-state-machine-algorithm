using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace End_automate
{
       class Program
    {
       

        static void Main(string[] args)
        {
            PinCreation myPin = new PinCreation(); //Creation of PinCreation class instance
            int[] newPin; //Creation of the array, which stores each number of the new pin
            myPin.CreatePin(out newPin); //Creation of the customer pin-code
            foreach (var number in newPin)
            {
                Console.Write(number);
            }

            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("Try to break in the pin-code");//Suppose, that someone else entered the pin-code earlier

            PinBreaking myBreaking = new PinBreaking(newPin);
            myBreaking.CheckNumbers();

           Console.ReadKey();
        }
    }
}
