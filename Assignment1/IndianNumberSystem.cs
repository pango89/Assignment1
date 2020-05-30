using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class IndianNumberSystem : INumberToWord
    {
        public string ConvertNumberToWord(int number)
        {
            if (number == 0)
                return Constants.zero;

            if (number < 0)
                return Constants.negative + Constants.space + ConvertNumberToWord(-1 * number);                       

            string suffix = Convert100s(number % 1000);
            string prefix = Convert1000s(number / 1000);
            string str = prefix.Trim() + Constants.space + suffix.Trim();
            return str.Trim();
        }

        private string Convert1000s(int number)
        {
            string str = "";

            int count = 0;
            while(number > 0)
            {
                if(number % 100 != 0)
                {
                    str = Convert10s(number % 100) + Constants.bigsIndian[count] + Constants.space + str;
                }

                number /= 100;
                count++;
            }

            return str;
        }

        // Utility method to convert upto 999
        private string Convert100s(int number)
        {
            string str = "";

            if (number > 100)
            {
                str += Constants.digits[number / 100 - 1] + Constants.space + Constants.hundred + Constants.space;
                number %= 100;
            }

            str += Convert10s(number);

            return str;
        }

        // Utility method to convert upto 99
        private string Convert10s(int number)
        {
            string str = "";            

            if (number >= 11 && number <= 19)
            {
                return str + Constants.teens[number - 11] + Constants.space;
            }

            if (number == 10 || number >= 20)
            {
                str += Constants.tens[number / 10 - 1] + Constants.space;
                number %= 10;
            }

            if (number >= 1 && number <= 9)
            {
                str += Constants.digits[number - 1] + Constants.space;
            }

            return str;
        }
    }
}
