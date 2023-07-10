using Katalyst.PasswordValidation.Validators;

namespace Katalyst.PasswordValidation;

public class ValidationBuilder
{
	private int _minimumLenght;
	private bool _validateUpperCase;
	private bool _validateLowerCase;
	private bool _validateNumber;
	private bool _validateUnderscore;


	public ValidationBuilder WithMinimumCharacters(int minimumCharacter)
	{
		_minimumLenght = minimumCharacter;
		return this;
	}

	public ValidationBuilder WithCapitalLetter()
	{
		_validateUpperCase = true;
		return this;
	}

	public ValidationBuilder WithLowerCaseLetter()
	{
		_validateLowerCase = true;
		return this;

	}

	public ValidationBuilder WithNumber()
	{
		_validateNumber = true;
		return this;
	}

	public ValidationBuilder WithUnderScore()
	{
		_validateUnderscore = true;
		return this;
	}

	public ValidationResult Validate(string password)
	{
		var invalidationResults = new List<InvalidationResult>();

		LenghtValidator.Validate(_minimumLenght, password, invalidationResults);
		UppercaseValidator.Validate(_validateUpperCase, password, invalidationResults);
		LowercaseValidator.Validate(_validateLowerCase, password, invalidationResults);
		NumbersValidator.Validate(_validateNumber, password, invalidationResults);
		UnderscoreValidator.Validate(_validateUnderscore, password, invalidationResults);

		return new ValidationResult
		{
			IsValid = IsValid(invalidationResults),
			InvalidationResults = invalidationResults
		};
	}

	private static bool IsValid(List<InvalidationResult> invalidationResults)
	{
		return !invalidationResults.Any();
	}

	public ValidationResult Validate4(string password)
	{
		var invalidationResults = new List<InvalidationResult>();

		LenghtValidator.Validate(_minimumLenght, password, invalidationResults);
		UppercaseValidator.Validate(_validateUpperCase, password, invalidationResults);
		LowercaseValidator.Validate(_validateLowerCase, password, invalidationResults);
		NumbersValidator.Validate(_validateNumber, password, invalidationResults);
		UnderscoreValidator.Validate(_validateUnderscore, password, invalidationResults);

		return new ValidationResult
		{
			IsValid = IsValid4(invalidationResults),
			InvalidationResults = invalidationResults
		};
	}

	private static bool IsValid4(List<InvalidationResult> invalidationResults)
	{
		return invalidationResults.Count <= 1;
	}
}