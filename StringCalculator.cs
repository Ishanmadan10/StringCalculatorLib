using System;
using System.Linq;

namespace UnitTesting1
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            HandleNegativeInput(numbers);

            if (numbers.All(char.IsDigit))
            {
                return ParseSingleNumber(numbers);
            }

            return SumNumbers(numbers);
        }

        private static void HandleNegativeInput(string numbers)
        {
            if (numbers.StartsWith("-"))
            {
                throw new ArgumentException("Negatives not allowed: " + numbers);
            }
        }

        private static int ParseSingleNumber(string numbers)
        {
            int number = int.Parse(numbers);
            if (number > 1000)
            {
                throw new ArgumentException("Numbers greater than 1000 are not allowed: " + number);
            }
            return number;
        }

        private static int SumNumbers(string numbers)
        {
            var parsedNumbers = numbers
                .Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(num => num <= 1000);

            return parsedNumbers.Sum();
        }
    }
}
