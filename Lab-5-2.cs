using System;

namespace Labs
{
    public static class Program
    {

        static char[] digits;
        public static void Main()
        {
            digits = new char[10];
            for (int i = 0; i < digits.Length; i++)
                digits[i] =(char) ('0' + i);

            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            if (!CheckIfInputIsCorrect(input))
                Console.WriteLine("Некорректный ввод");
            else
                Console.WriteLine($"Сумма цифр: {GetSum(input)}");

        }

        public static bool CheckIfInputIsCorrect(string input)
        {
            bool flag = true;
            if (input == "") return false;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 && input.Length > 1 && input[i] == '-')
                    continue;
                if (!digits.Contains(input[i]))
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