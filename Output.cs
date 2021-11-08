using System;

namespace Sorting
{
    class Output : Sorting
    {
        public void Print()
        {
            Sort(out string output, out bool result, out string exit);            
            if (result)
            {                
                Console.WriteLine(output);
            }
            else if (exit == "Выход")
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
