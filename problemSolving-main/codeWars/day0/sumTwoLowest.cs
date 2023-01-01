Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

[10, 343445353, 3453445, 3453545353453] should return 3453455.


using System;
using System.Linq;
public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		int min1 = numbers.Min();
    numbers = numbers.Where(e => e!= min1).ToArray();
    int min2 = numbers.Min();
    //Code here...
    
    return min1 + min2;
	}
}