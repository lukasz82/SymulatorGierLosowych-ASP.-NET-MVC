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

        public int [] ReturnNumbers(int howManyNumbers)
        {
            for (int i = 1; i <= howManyNumbers; i++)
            {
                // Przy pierwszym wejściu losuje po prostu numer
                if (numbers.Count == 0)
                {
                    number = rnd.Next(1, 49);
                }
                
                // Zabezpieczenie przed duplikowaniem się numerów
                while (numbers.Contains(number))
                {
                    number = rnd.Next(1, 49);
                }
                numbers.Push(number);
            }   
            var numbersSorted = numbers.OrderBy(num => num).ToArray();
            return numbersSorted;
        }

        public int ReturnSingleNumber()
        {
            number = rnd.Next(1, 49);
            return number;
        }
    }
}
