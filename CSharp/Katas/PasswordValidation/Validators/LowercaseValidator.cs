namespace Katas.PasswordValidation.Validators;

public static class LowercaseValidator
{
	public static void Validate(bool validateLowerCase, string password,
												 List<InvalidationResult> invalidationResults)
	{
		if (validateLowerCase && !HasALowerCaseLetter(password))
		{
			invalidationResults.Add(InvalidationResult.DoesNotContainLowerCaseLetter);
		}
	}
	
	private static bool HasALowerCaseLetter(string password)
	{
		return password.Any(char.IsLower);
	}
}