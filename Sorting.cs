namespace Sorting
{
    class Sorting : Parser
    {
        public void Sort(out string output, out bool result, out string exit)
        {
            Parse(out int[] number, out bool res, out string _exit);
            if (res)
            {
                int timeNumber;
                for (int i = 0; i < number.Length - 1; i++)
                {
                    for (int j = i + 1; j < number.Length; j++)
                    {
                        if (number[i] > number[j])
                        {
                            timeNumber = number[i];
                            number[i] = number[j];
                            number[j] = timeNumber;
                        }
                    }
                }
                output = string.Join(" ", number);
                result = res;
            }
            else
            {
                output = "";
                result = res;
            }
            exit = _exit;
        }
    }
}
