using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymulatorGierLosowych.ClassOfGenerators
{
    public class RandomNumbersGenerator
    {

        private Random rnd = new Random();
        private int number;
        Stack<int> numbers = new Stack<int>();

        public Stack<int> ReturnNumbers(int howManyNumbers)
        {
            for (int i = 1; i <= howManyNumbers; i++)
            {
                number = rnd.Next(1, 49);
                numbers.Push(number);
            }   
            return numbers;
        }

        public int ReturnSingleNumber()
        {
            number = rnd.Next(1, 49);
            return number;
        }
    }
}
