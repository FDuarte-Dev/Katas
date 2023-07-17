using Codewars.Rectangle_into_squares;
using FluentAssertions;

namespace Codewars.Test.Rectangle_into_squares;

public class SqInRectShould
{
	[Fact]
	public static void ReturnNullOnGivenSquare()
	{
		var result = SqInRect.Execute(5, 5);

		result.Should().BeNull();
	}
	
	[Fact]
	public static void ReturnSquareListOnGivenRectangle()
	{
		var result = SqInRect.Execute(5, 3);

		result.Should().BeEquivalentTo(new List<int>(){3,2,1,1});
	}
	
	[Fact]
	public static void ReturnSquareListOnGivenTwoBlockNarrowRectangle()
	{
		var result = SqInRect.Execute(5, 2);

		result.Should().BeEquivalentTo(new List<int>(){2,2,1,1});
	}
	
	[Fact]
	public static void ReturnSquareListOnGivenOneBlockNarrowRectangle()
	{
		var result = SqInRect.Execute(5, 1);

		result.Should().BeEquivalentTo(new List<int>(){1,1,1,1,1});
	}
}