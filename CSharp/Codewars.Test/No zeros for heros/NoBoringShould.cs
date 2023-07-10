using Codewars.No_zeros_for_heros;
using FluentAssertions;

namespace Codewars.Test.No_zeros_for_heros;

public class NoBoringShould
{
	[Fact]
	public static void KeepLonelyZero()
	{
		var result = NoBoring.NoBoringZeros(0);

		result.Should().Be(0);
	}

	[Theory]
	[InlineData(1450, 145)]
	[InlineData(960000, 96)]
	[InlineData(1050, 105)]
	[InlineData(-1050, -105)]
	public static void RemoveTrailingZeros(int number, int expected)
	{
		var result = NoBoring.NoBoringZeros(number);


		result.Should().Be(expected);
	}
	
	[Fact]
	public static void KeepValueWithoutTrailingZeros()
	{
		var result = NoBoring.NoBoringZeros(1);

		result.Should().Be(1);
	}
}