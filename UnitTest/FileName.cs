using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class FileName
    {
        //Basics
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        //Strings
        public string Concat(string str1,string str2)
        {
            return str1 + str2;
        }
        public string SubString(string str,int index)
        {
            return str.Substring(index);
        }
        public string ReplaceString(string str,string word1,string word2)
        {
            return str.Replace(word1, word2);
        }
        public string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public bool Palindrome(string input)
        {
            string rev = ReverseString(input);
            return input.Equals(rev,StringComparison.OrdinalIgnoreCase);
        }
        public int LengthString(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            return input.Length;
        }
        //Arrays
        public int Sum(int[] numbers)
        {
            int sum = 0; 
            foreach (int number in numbers)
                sum += number;
            return sum;
        }
        public double Average(int[] numbers)
        {
            return (double) Sum(numbers) / numbers.Length;
        }
        public int Max(int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
                if (number > max)
                    max = number;
            return max;
        }
        public int Min(int[] numbers)
        {
            int min = numbers[0];
            foreach (int number in numbers)
                if (number < min)
                    min = number;
            return min;
        }
        public int[] Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
            return numbers;
        }
        public int[] Sort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
        public int[] Copy(int[] arr1, int[] arr2)
        {
            Array.Copy(arr1, arr2, arr1.Length);
            return arr2;
        }
        public int Length(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array is empty");
            return numbers.Length;
        }

    }
}
