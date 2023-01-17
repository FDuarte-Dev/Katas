namespace Katas.PasswordValidation;

public static class PasswordValidator
{
	public static bool Validate(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(8)
			   .WithCapitalLetter()
			   .WithLowerCaseLetter()
			   .WithNumber()
			   .WithUnderScore()
			   .Validate(password);
	}
	
	public static bool Validate2(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(6)
			   .WithCapitalLetter()
			   .WithLowerCaseLetter()
			   .WithNumber()
			   .Validate(password);
	}

	public static bool Validate3(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(16)
			   .WithCapitalLetter()
			   .WithLowerCaseLetter()
			   .WithUnderScore()
			   .Validate(password);
	}
}