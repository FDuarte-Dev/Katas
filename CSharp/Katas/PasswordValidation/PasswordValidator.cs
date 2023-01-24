namespace Katas.PasswordValidation;

public static class PasswordValidator
{
	public static ValidationResult Validate(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(8)
			   .WithCapitalLetter()
			   .WithLowerCaseLetter()
			   .WithNumber()
			   .WithUnderScore()
			   .Validate(password);
	}
	
	public static ValidationResult Validate2(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(6)
			   .WithCapitalLetter()
			   .WithLowerCaseLetter()
			   .WithNumber()
			   .Validate(password);
	}

	public static ValidationResult Validate3(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(16)
			   .WithCapitalLetter()
			   .WithLowerCaseLetter()
			   .WithUnderScore()
			   .Validate(password);
	}

	public static ValidationResult Validate4(string password)
	{
		return new ValidationBuilder()
			   .WithMinimumCharacters(9)
			   .WithCapitalLetter()
			   .WithNumber()
			   .WithUnderScore()
			   .Validate4(password);
	}
}