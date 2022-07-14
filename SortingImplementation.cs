using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class SortingImplementation
    {
        public double[] Tuple(double[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                        (numbers[i], numbers[j]) = (numbers[j], numbers[i]);  //Меняем кортежем местами числа
                }
            }
            return numbers;
        }
        public double[] Bubble(double[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    double temporary;

                    if (numbers[i] > numbers[j])
                    {
                        temporary = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temporary;
                    }
                }
            }
            return numbers;
        }
    }
}
