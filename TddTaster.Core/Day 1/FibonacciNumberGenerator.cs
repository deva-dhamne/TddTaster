namespace TddTaster.Core.Day1
{
    public class FibonacciNumberGenerator
    {
        public static int GetNumberFor(int position)
        {
            if (position <= 0) 
                return 0;

            if (position == 1) 
                return 1;

            return GetNumberFor(position - 1) + GetNumberFor(position - 2);
        }
    }
}
