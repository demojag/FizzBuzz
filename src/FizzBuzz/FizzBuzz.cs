using System.Globalization;

namespace FizzBuzzCore
{
    public static class FizzBuzz
    {
        public static string CheckFizzBuzz(int input)
        {
            if (input % 5 == 0 && input % 3 == 0)
                return "FizzBuzz";
            if (input % 5 == 0)
                return "Buzz";
            return input % 3 == 0 ? "Fizz" : input.ToString(CultureInfo.InvariantCulture);
        }
    }
}
