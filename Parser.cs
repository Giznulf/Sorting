using System;
using System.Text.RegularExpressions;

namespace Sorting
{
    class Parser : Input
    {        
        public void Parse(out int[] numbers, out bool result, out string exit)
        {
            Inputs(out string input);
            try
            {
                string[] parse = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                exit = input.Replace(" ", "");
                string pattern = @"[0-9]";
                bool res = Regex.IsMatch(exit, pattern);
                result = res;
                if (result)
                {
                    numbers = Array.ConvertAll(parse, new Converter<string, int>(Converter));
                }
                else
                {
                    numbers = new int[0];
                }
            }
            catch
            {
                numbers = new int[0];
                result = false;
                exit = "";
            }           
        }
        public int Converter(string i)
        {
            int number = int.Parse(i);
            return number;
        }
    }
}
