namespace Katas.PasswordValidation;

public class PasswordValidator
{
	public static bool Validate(string password)
	{
		return HasEightOrMoreCharacters(password) &&
			   HasACapitalLetter(password) &&
			   HasALowerCaseLetter(password) &&
			   HasANumber(password) &&
			   HasAnUnderscore(password);
	}

	private static bool HasEightOrMoreCharacters(string password)
	{
		return password.Length >= 8;
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