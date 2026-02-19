using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Software_Engineer
{
    public class IntToAlien
    {
        public string Converting(int number)
        {
            if (number < 0)
                return "number must more than 0";

            return ConvertIntToAlien(number);
        }

        public string ConvertIntToAlien(int number)
        {
            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;
            int tens = (number % 100) / 10;
            int ones = number % 10;

            string result = "";

            //Thousands (R = 1000)
            for (int i = 0; i < thousands; i++)
            {
                result += "R";
            }

            //Hundreds (C=100, D=500, R=1000)
            result += ConvertDigit(hundreds, "C", "D", "R");

            //Tens (Z=10, L=50, C=100)
            result += ConvertDigit(tens, "Z", "L", "C");

            //Ones (A=1, B=5, Z=10)
            result += ConvertDigit(ones, "A", "B", "Z");

            return result;
        }

        private string ConvertDigit(int digit, string one, string five, string ten)
        {
            if (digit == 9)
                return one + ten;

            if (digit >= 5)
                return five + new string(one[0], digit - 5);

            if (digit == 4)
                return one + five;

            return new string(one[0], digit);
        }
    }
}
