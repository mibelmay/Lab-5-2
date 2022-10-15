using System;

namespace Labs
{
    public static class Program
    { 
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(CheckIfInputIsCorrect(input));
        }

        public static bool CheckIfInputIsCorrect(string input)
        {
            char[] digits = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            bool flag = false;
            if (input == "") return flag;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input[i] == '-')
                    continue;
                if (digits.Contains(input[i]))
                    flag = true;
                else flag = false;
            }
            return flag;
        }
    }

}