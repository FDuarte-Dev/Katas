namespace Katalyst.PasswordValidation.Validators;

public static class NumbersValidator
{
	public static void Validate(bool validateNumber, string password,
											   List<InvalidationResult> invalidationResults)
	{
		if (validateNumber && !HasANumber(password))
		{
			invalidationResults.Add(InvalidationResult.DoesNotContainNumbers);
		}
	}
	
	private static bool HasANumber(string password)
	{
		return password.Any(char.IsNumber);
	}
}