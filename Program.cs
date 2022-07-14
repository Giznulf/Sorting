using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Program sorting = new Program();
            while (true)
            {
                sorting.Output();
            }
        }
        public string Input()
        {
            Console.Write("Введите числа через пробел: ");
            return Console.ReadLine();
        } 
        public void ValidationAndConversion(string inputString,out double[] numbers)  //Валидация и конвертация
        {
            if(Regex.IsMatch(inputString, @"(-?[0-9]+(\.{1}[0-9]+)?){1,}"))  //Проверка на числа
            {
                string[] parseString = inputString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                numbers = parseString.Select(x => double.Parse(x)).ToArray();
            }
            else numbers = new double[0];                
        }

        public double[] Sorting(double[] numbers) => numbers.OrderBy(n => n).ToArray();  //Сортировка

        public void Output()
        {
            SortingImplementation sorting = new SortingImplementation();
            try
            {
                string inputStrig = Input();                           //Получение вводимой строки
                ValidationAndConversion(inputStrig, out double[] unsortedNumbers);   //Проверка на корректность и получение ассива чисел

                Console.WriteLine($"Сортировка корежем {string.Join(" ", sorting.Tuple(unsortedNumbers))}");

                Console.WriteLine($"Сортировка пузырьком {string.Join(" ", sorting.Bubble(unsortedNumbers))}");

                Console.WriteLine($"Сортировка LINQ {string.Join(" ", Sorting(unsortedNumbers))}"); 
            }
            catch
            {
                Console.WriteLine("Не все введеные значения являються числам, попробуйте еще раз."); //Исключение в случае ошибки
            }            
        }
    }
}
