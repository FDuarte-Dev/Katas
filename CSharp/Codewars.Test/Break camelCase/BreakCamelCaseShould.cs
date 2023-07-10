using Codewars.Break_camelCase;
using FluentAssertions;

namespace Codewars.Test.Break_camelCase;

public class BreakCamelCaseShould
{
	[Fact]
	public static void AddSpaceBetweenWords()
	{
		// Arrange
		const string words = "camelCasing";
		
		// Act
		var result = BreakCamelCase.Execute(words);

		// Assert
		result.Should().Be("camel Casing");
	}

	[Fact]
	public static void KeepOneWordTheSame()
	{
		// Arrange
		const string words = "one";
		
		// Act
		var result = BreakCamelCase.Execute(words);

		// Assert
		result.Should().Be("one");
	}

	[Fact]
	public static void KeepEmptyWordsEmpty()
	{
		// Arrange
		const string words = "";
		
		// Act
		var result = BreakCamelCase.Execute(words);

		// Assert
		result.Should().BeEmpty();
	}
}