using System;
using System.Text.RegularExpressions;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                program.Output();
            }
        }
        public string Input()
        {
            Console.Write("Введите числа через пробел: ");
            string input = Console.ReadLine();
            return input;
        }
        public void Parse(out int[] numbers, out bool hasNumber, out string filterString)
        {
            string inputStrig = Input();
            try
            {
                string[] parseString = inputStrig.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                filterString = inputStrig.Replace(" ", "");
                string pattern = @"[0-9]";
                hasNumber = Regex.IsMatch(filterString, pattern);
                if (hasNumber)
                {
                    numbers = Array.ConvertAll(parseString, new Converter<string, int>(Converter));
                }
                else
                {
                    numbers = new int[0];
                }
            }
            catch
            {
                numbers = new int[0];
                hasNumber = false;
                filterString = "";
            }

            int Converter(string i)
            {
                int number = int.Parse(i);
                return number;
            }
        }
        public void Sort(out string stringNumbers, out bool hasNumber, out string exitProgram)
        {
            Parse(out int[] numbers, out hasNumber, out exitProgram);
            if (hasNumber)
            {                
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            int x;

                            x = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = x;
                        }
                    }
                }
                stringNumbers = string.Join(" ", numbers);
            }
            else
            {
                stringNumbers = "";
            }
        }
        public void Output()
        {
            Sort(out string outputMessage, out bool hasNumber, out string exitProgram);
            if (hasNumber)
            {
                Console.WriteLine(outputMessage);
            }
            else if (exitProgram == "Выход")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Не все введеные значения являються числам, попробуйте еще раз.");
            }
            Console.WriteLine("Введите 'Выход' чтобы завершить.\n");
        }
    }
}
