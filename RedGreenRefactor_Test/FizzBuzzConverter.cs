using System;

namespace RedGreenRefactor_Test
{
    public class FizzBuzzConverter
    {
        public string Convert(int value)
        {
            if (value % 15 == 0) return "FizzBuzz";
            if (value % 5 == 0) return "Buzz";
            if (value % 3 == 0) return "Fizz";
            
            return value.ToString();
        }
    }
}