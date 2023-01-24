namespace Katas.PasswordValidation.Validators;

public static class UppercaseValidator
{
	public static void Validate(bool validateUpperCase, string password,
												 List<InvalidationResult> invalidationResults)
	{
		if (validateUpperCase && !HasACapitalLetter(password))
		{
			invalidationResults.Add(InvalidationResult.DoesNotContainCapitalLetter);
		}
	}
	
	private static bool HasACapitalLetter(string password)
	{
		return password.Any(char.IsUpper);
	}
}