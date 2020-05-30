using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class NumberSystem
    {
        private INumberToWord NumberToWordConverter { get; set; }

        public NumberSystem(INumberToWord numberToWordConverter)
        {
            this.NumberToWordConverter = numberToWordConverter;
        }

        public string Convert(int number)
        {
            return this.NumberToWordConverter.ConvertNumberToWord(number);
        }
    }
}
