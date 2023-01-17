using FluentAssertions;
using Katas.PasswordValidation;

namespace Katas.Test.PasswordValidation;

public class PasswordValidationShould
{
	[Fact]
	public void InvalidatePasswordWithLessThanEightCharacters()
	{
		// Arrange
		const string password = "1234567";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.Should().BeFalse();
	}

	[Fact]
	public void InvalidatePasswordWithoutACapitalLetter()
	{
		// Arrange
		const string password = "aaaaaaaa";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.Should().BeFalse();
	}

	[Fact]
	public void InvalidatePasswordWithoutALowerCaseLetter()
	{
		// Arrange
		const string password = "AAAAAAAA";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.Should().BeFalse();
	}

	[Fact]
	public void InvalidatePasswordWithoutANumber()
	{
		// Arrange
		const string password = "aaaaAAAA";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.Should().BeFalse();
	}

	[Fact]
	public void InvalidatePasswordWithoutAnUnderscore()
	{
		// Arrange
		const string password = "aaaAAA123";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.Should().BeFalse();
	}
}