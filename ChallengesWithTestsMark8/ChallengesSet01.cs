﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var result = minuend - subtrahend;
            return result;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
               return number1;
            }
            return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return String.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
