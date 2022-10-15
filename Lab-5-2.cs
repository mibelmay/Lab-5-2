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
                Console.WriteLine($"Сумма цифр: {GetSum(input)}");

        }

        public static bool CheckIfInputIsCorrect(string input)
        {
            bool flag = false;
            if (input == "") return flag;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input[i] == '-')
                    continue;
                if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(input[i]))
                    flag = false;
            }
            return flag;
        }

        public static int GetSum(string input)
        {
            input = input.Replace("-", "");
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                    if (j == input[i]-'0')
                        sum += j;
            }
            return sum;
        }

    }

}