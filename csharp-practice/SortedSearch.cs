using System;

namespace sortedS
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            // This works but it's inneficient.
            int length = sortedArray.Length - 1;
            // I could find a more efficient way to do this.
            int div = (int)Math.Ceiling((double)length / 2.0);
            int currentNum = sortedArray[div];
            while (true)
            {
                if (currentNum == lessThan)
                {
                    return div;
                }
                if (currentNum < lessThan)
                {
                    if (sortedArray[div + 1] > lessThan)
                    {
                        return div + 1;
                    }
                    else
                    {
                        div = (int)Math.Ceiling(3.0 * (double)div / 2.0);
                    }
                }
                if (currentNum > lessThan)
                {
                    if (sortedArray[div - 1] < lessThan)
                    {
                        return div;
                    }
                    else
                    {
                        div = (int)Math.Ceiling((double)div / 2.0);
                    }
                }
            }
            // throw new NotImplementedException("Waiting to be implemented.");
        }

        // public static void Main(string[] args)
        // {
        //     // Ir al medio de fijo.
        //     Console.WriteLine(Math.Ceiling((double)5 / (double)2));
        //     Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        // }
    }

}