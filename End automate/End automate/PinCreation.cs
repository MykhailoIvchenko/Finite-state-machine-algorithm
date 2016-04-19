using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace End_automate
{
    class PinCreation // The class allows to create customer pin-code
    {
        public void CreatePin (out int [] newPin)
        {
            bool checker = true; // The boolean variable serves to determine if all rules of pin creation are followed
            newPin = new int[4]; 
            while (checker == true) // The loop will be repeated if the customer makes something wrong
            {
                Console.WriteLine("Enter four numbers to create your new pin-code");
                string enteredPid = Console.ReadLine();
                char [] pinNumbers = enteredPid.ToCharArray();
                if (pinNumbers.Length < 4) //Check the number of entered symbols
                {
                    Console.WriteLine("You have entered less, then four symbols. Please, try again:");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue; //Go to the next iteration of the loop because of invalid quantity of symbols
                }
                else if (pinNumbers.Length > 4)
                {
                    Console.WriteLine("You have entered more, then four symbols. Please, try again:");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue; //Go to the next iteration of the loop because of invalid quantity of symbols
                }
                
                int n; // The variable for receiving each number of pin in the integer format
                int i = 0; // The counter for newPin array indexes
                foreach (var number in pinNumbers) //The loop cheks if all entered symbols are numbers
                {
                   bool result = int.TryParse(number.ToString(), out n);
                   if (result)
                   {
                       newPin[i] = n;
                       i++;
                   }
                   else
                   {
                       Console.WriteLine("You have entered forbidden symbols. Not all symbols are numbers. Please, try again:");
                       Thread.Sleep(2000);
                       Console.Clear();
                       i = 0;
                       break;
                   }
                }
                if (i == 0)
                {
                    continue; //Go to the next iteration of the loop because of entering forbidden symbols (not numbers)
                }
                Console.WriteLine("New pin-code has been created");
                checker = false;
            }
           
        }
    }
}
