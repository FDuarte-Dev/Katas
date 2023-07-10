namespace Codewars.Human_readable_time;

public static class Timeformat
{
	public static string GetReadableTime(int seconds)
	{
		var hours = GetHours(seconds);
		var minutes = GetMinutes(seconds);

		return $"{hours:00}:{minutes:00}:{seconds:00}";
		
		int GetHours(int i)
		{
			var secondsHours = i / 3600;
			seconds = i % 3600;
			return secondsHours;
		}
		
		int GetMinutes(int i)
		{
			var getMinutes = i / 60;
			seconds = i % 60;
			return getMinutes;
		}
	}
}