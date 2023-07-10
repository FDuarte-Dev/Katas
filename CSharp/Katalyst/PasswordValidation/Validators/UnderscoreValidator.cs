namespace Katalyst.PasswordValidation.Validators;

public static class UnderscoreValidator
{
	public static void Validate(bool validateUnderscore, string password,
												  List<InvalidationResult> invalidationResults)
	{
		if (validateUnderscore && !HasAnUnderscore(password))
		{
			invalidationResults.Add(InvalidationResult.DoesNotContainUnderscore);
		}
	}
	
	private static bool HasAnUnderscore(string password)
	{
		return password.Any(c => c.Equals('_'));
	}
}