using System;

namespace Labs
{
    public static class Program
    { 
        public static void Main()
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            if (!CheckIfInputIsCorrect(input))
                Console.WriteLine("Введено некорректное число");
            else
                Console.WriteLine("Число корректно");

        }

        public static bool CheckIfInputIsCorrect(string input)
        {
            bool flag = false;
            if (input == "" || input.Contains(',') || input.Contains('.')) return flag;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input[i] == '-')
                    continue;
                if (new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(input[i]))
                    flag = true;
                else flag = false;
            }
            return flag;
        }


    }

}