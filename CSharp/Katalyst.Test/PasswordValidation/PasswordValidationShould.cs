using FluentAssertions;
using Katalyst.PasswordValidation;

namespace Katalyst.Test.PasswordValidation;

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
		result.IsValid.Should().BeFalse();
		result.InvalidationResults.Should().Contain(InvalidationResult.NotEnoughPasswordLenght);
	}

	[Fact]
	public void InvalidatePasswordWithoutACapitalLetter()
	{
		// Arrange
		const string password = "aaaaaaaa";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.IsValid.Should().BeFalse();
		result.InvalidationResults.Should().Contain(InvalidationResult.DoesNotContainCapitalLetter);
	}

	[Fact]
	public void InvalidatePasswordWithoutALowerCaseLetter()
	{
		// Arrange
		const string password = "AAAAAAAA";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.IsValid.Should().BeFalse();
		result.InvalidationResults.Should().Contain(InvalidationResult.DoesNotContainLowerCaseLetter);
	}

	[Fact]
	public void InvalidatePasswordWithoutANumber()
	{
		// Arrange
		const string password = "aaaaAAAA";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.IsValid.Should().BeFalse();
		result.InvalidationResults.Should().Contain(InvalidationResult.DoesNotContainNumbers);
	}

	[Fact]
	public void InvalidatePasswordWithoutAnUnderscore()
	{
		// Arrange
		const string password = "aaaAAA123";

		// Act
		var result = PasswordValidator.Validate(password);
		
		// Assert
		result.IsValid.Should().BeFalse();
		result.InvalidationResults.Should().Contain(InvalidationResult.DoesNotContainUnderscore);
	}

	[Theory]
	[InlineData("12345")]
	[InlineData("aaaaaa")]
	[InlineData("AAAAAA")]
	[InlineData("aaaAAA")]
	public void InvalidatePasswordsForSecondValidation(string password)
	{
		// Act
		var result = PasswordValidator.Validate2(password);
		
		// Assert
		result.IsValid.Should().BeFalse();
	}
	
	[Theory]
	[InlineData("123456789012345")]
	[InlineData("aaaaaaaaaaaaaaaa")]
	[InlineData("AAAAAAAAAAAAAAAA")]
	[InlineData("aaaaaaaaAAAAAAAA")]
	public void InvalidatePasswordsForThirdValidation(string password)
	{
		// Act
		var result = PasswordValidator.Validate3(password);
		
		// Assert
		result.IsValid.Should().BeFalse();
	}
	
	[Fact]
	public void ValidatePasswordWithOneValidationError()
	{
		// Arrange
		const string password = "A23456789";

		// Act
		var result = PasswordValidator.Validate4(password);
		
		// Assert
		result.IsValid.Should().BeTrue();
		result.InvalidationResults.Should().Contain(InvalidationResult.DoesNotContainUnderscore);
	}
}