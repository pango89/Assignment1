namespace Assignment1
{
    public class NumberSystem
    {
        // Converter can be either Indian or Internation type based on dependncy injection 
        public INumberToWord NumberToWordConverter { get; private set; }

        // Inject dependency via Constructor Injection
        public NumberSystem(INumberToWord numberToWordConverter)
        {
            this.NumberToWordConverter = numberToWordConverter;
        }

        // Method for number to word conversion
        public string Convert(long number)
        {
            return this.NumberToWordConverter.ConvertNumberToWord(number);
        }
    }
}
