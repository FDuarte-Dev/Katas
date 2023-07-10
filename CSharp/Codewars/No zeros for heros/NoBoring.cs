namespace Codewars.No_zeros_for_heros;

public static class NoBoring
{
	public static int NoBoringZeros(int n) 
	{
		if (IsZeroCase())
		{
			return n;
		}
      
		while(EndsWithZero())
		{
			n = RemoveTrailingZero(n);
		}
      
		return n;
      
		bool IsZeroCase() 
			=> n == 0;
      
		bool EndsWithZero() 
			=> n % 10 == 0;
      
		int RemoveTrailingZero(int number) 
			=> number / 10;
	}
}