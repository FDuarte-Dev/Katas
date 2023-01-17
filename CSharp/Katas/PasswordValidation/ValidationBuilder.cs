namespace Katas.PasswordValidation;

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
		return this;	}

	public ValidationResult Validate(string password)
	{
		var isValid = true;
		var invalidationResults = new List<InvalidationResult>();
		
		if (_minimumLenght > 0)
		{
			var hasNumberOfCharacters = MinimumNumberOfCharacters(password);
			isValid &= hasNumberOfCharacters;
			if (!hasNumberOfCharacters)
			{
				invalidationResults.Add(InvalidationResult.NotEnoughPasswordLenght);
			}
		}

		if (_validateUpperCase)
		{
			var hasCapitalLetter = HasACapitalLetter(password);
			isValid &= hasCapitalLetter;
			if (!hasCapitalLetter)
			{
				invalidationResults.Add(InvalidationResult.DoesNotContainCapitalLetter);
			}
		}

		if (_validateLowerCase)
		{
			var hasLowerCaseLetter = HasALowerCaseLetter(password);
			isValid &= hasLowerCaseLetter;
			if (!hasLowerCaseLetter)
			{
				invalidationResults.Add(InvalidationResult.DoesNotContainLowerCaseLetter);
			}
		}

		if (_validateNumber)
		{
			var hasNumber = HasANumber(password);
			isValid &= hasNumber;
			if (!hasNumber)
			{
				invalidationResults.Add(InvalidationResult.DoesNotContainNumbers);
			}
		}

		if (_validateUnderscore)
		{
			var hasUnderscore = HasAnUnderscore(password);
			isValid &= hasUnderscore;
			if (!hasUnderscore)
			{
				invalidationResults.Add(InvalidationResult.DoesNotContainUnderscore);
			}
		}
		
		return new ValidationResult()
		{
			IsValid = isValid,
			InvalidationResults = invalidationResults
		};
	}
	
	private bool MinimumNumberOfCharacters(string password)
	{
		return password.Length >= _minimumLenght;
	}
	
	private static bool HasACapitalLetter(string password)
	{
		return password.Any(char.IsUpper);
	}
	
	private static bool HasALowerCaseLetter(string password)
	{
		return password.Any(char.IsLower);
	}
	
	private static bool HasANumber(string password)
	{
		return password.Any(char.IsNumber);
	}
	
	private static bool HasAnUnderscore(string password)
	{
		return password.Any(c => c.Equals('_'));
	}
}