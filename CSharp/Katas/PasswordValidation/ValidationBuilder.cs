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

	public bool Validate(string password)
	{
		var isValid = true;
		
		if (_minimumLenght > 0)
		{
			isValid &= MinimumNumberOfCharacters(password);
		}

		if (_validateUpperCase)
		{
			isValid &= HasACapitalLetter(password);
		}

		if (_validateLowerCase)
		{
			isValid &= HasALowerCaseLetter(password);
		}

		if (_validateNumber)
		{
			isValid &= HasANumber(password);
		}

		if (_validateUnderscore)
		{
			isValid &= HasAnUnderscore(password);
		}

		return isValid;
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