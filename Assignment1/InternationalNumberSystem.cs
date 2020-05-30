namespace Assignment1
{
    public class InternationalNumberSystem : INumberToWord
    {
        // Method to convert number to word
        public string ConvertNumberToWord(long number)
        {
            if (number == 0)
                return Constants.zero;

            if (number < 0)
                return Constants.negative + Constants.space + ConvertNumberToWord(-1 * number);

            int count = 0;
            string str = "";

            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    str = Convert100s(number % 1000) + Constants.bigs[count] + Constants.space + str;
                }

                number /= 1000;
                count++;
            }

            return str.Trim();
        }

        // Utility method to convert upto 999
        private string Convert100s(long number)
        {
            string str = "";

            if (number > 100)
            {
                str += Constants.digits[number / 100 - 1] + Constants.space + Constants.hundred + Constants.space;
                number %= 100;
            }

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
