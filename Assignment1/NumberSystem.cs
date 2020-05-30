namespace Assignment1
{
    public class NumberSystem
    {
        private INumberToWord NumberToWordConverter { get; set; }

        public NumberSystem(INumberToWord numberToWordConverter)
        {
            this.NumberToWordConverter = numberToWordConverter;
        }

        public string Convert(long number)
        {
            return this.NumberToWordConverter.ConvertNumberToWord(number);
        }
    }
}
