using System;
using System.Text;

namespace Prime.Services
{
    public class Test
    {
        public int[] Bubble(int[] array)
        {
            if (array.Length == 0)
            {
                return [-1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
                    }
                }
            }
            return array;
        }

        public bool Palindrome(string str)
        {
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                if (str[i] != str[j])
                    return false;
            return true;

        }

        public int Factorial(int number)
        {
            if (number < 0 || number >= 13)
            {
                return -1;
            }
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        public int Fibonachi(int number)
        {
            if (number < 0 || number > 47)
            {
                return -1;
            }

            if (number == 0 || number == 1) return number;

            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }

        public bool Substring(string str, string sub)
        {
            if (sub.Length > str.Length)
            {
                return false;
            }
            else if (str.Length == 0 && sub.Length == 0)
            {
                return true;
            }
            else if (str.Length == 0 || sub.Length == 0)
            {
                return false;
            }
            return str.Contains(sub);
        }

        public bool PrimeNumber(int number)
        {
            if (number < 0)
            {
                return false;
            }

            for (int i = 2; i < Math.Round(Math.Sqrt(number)); i++)
                if (number % i == 0)
                    return false;
            return true;
        }

        public int ReverseNumber(int number)
        {
            string str_number = number.ToString();
            if (str_number.Length == 1)
            {
                return number;
            }
            string reverse = new string(str_number.Reverse().ToArray());
            char minus = reverse[reverse.Length - 1];
            if (minus == '-')
            {
                string res = minus + reverse.Substring(0, reverse.Length - 1);
                if (long.Parse(res) <= 2147483647 && long.Parse(res) >= -2147483647)
                {
                    return int.Parse(res);
                }
            }
            if (long.Parse(reverse) <= 2147483647 && long.Parse(reverse) >= -2147483647)
            {
                return int.Parse(reverse);
            }

            return 0;
        }

        public string RomanNumber(int number)
        {
            if (number < 0 || number > 3999)
                return "error";

            if (number == 0) return "N";

            int[] numbers_dict = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman_dict = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numbers_dict.Length; i++)
            {
                while (number >= numbers_dict[i])
                {
                    number -= numbers_dict[i];
                    result.Append(roman_dict[i]);
                }
            }

            return result.ToString();
        }
    }

    public class Program
    {
        public static void Main()
        {

        }
    }
}