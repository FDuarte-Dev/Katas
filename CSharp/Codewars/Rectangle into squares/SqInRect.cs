namespace Codewars.Rectangle_into_squares;

public class SqInRect
{
	public static List<int> Execute(int lng, int wdth) {
		if (lng == wdth)
		{
			return null;
		}

		var squares = new List<int>();
		while (lng != wdth)
		{
			squares.Add(Math.Min(lng, wdth));
			if (lng > wdth)
			{
				lng -= wdth;
			}
			else
			{
				wdth -= lng;
			}
		}
		
		squares.Add(lng);

		return squares;
	}
}