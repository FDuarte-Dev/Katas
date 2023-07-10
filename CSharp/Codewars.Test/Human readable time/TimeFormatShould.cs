using Codewars.Human_readable_time;
using FluentAssertions;

namespace Codewars.Test.Human_readable_time;

public class TimeFormatShould
{
	[Theory]
	[InlineData("00:00:00", 0)]
	[InlineData("00:00:05", 5)]
	[InlineData("00:01:00", 60)]
	[InlineData("01:00:00", 3600)]
	[InlineData("23:59:59", 86399)]
	[InlineData("99:59:59", 359999)]
	public static void ReadHumanReadableTime(string expected, int seconds)
	{
		var result = Timeformat.GetReadableTime(seconds);

		result.Should().Be(expected);
	}
}