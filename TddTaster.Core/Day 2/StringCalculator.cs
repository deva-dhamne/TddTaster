namespace TddTaster.Core.Day_2
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == null)
                throw new ArgumentException("null not allowed");

            if (numbers == string.Empty)
                return 0;

            return PerformAdditionFor(numbers);
        }

        private static int PerformAdditionFor(string numbers)
        {
            var delimeters = GetDelimiters(numbers).ToArray();

            var numbersArray = numbers.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            var intNumbers = new List<int>();

            foreach (var number in numbersArray)
            {
                if (int.TryParse(number, out int intNumber))
                    intNumbers.Add(intNumber);
            }

            if (intNumbers.Any(x => x < 0))
                throw new ArgumentException("negatives not allowed");

            return intNumbers.Sum(x => x);
        }

        private static List<string> GetDelimiters(string numbers)
        {
            var delimiters = new List<string> { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(2);
                var customDelimiter = numbers.First().ToString();
                delimiters.Add(customDelimiter);
            }

            return delimiters;
        }
    }
}
