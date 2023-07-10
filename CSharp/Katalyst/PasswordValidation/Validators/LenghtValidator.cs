namespace Katalyst.PasswordValidation.Validators;

public static class LenghtValidator
{
	public static void Validate(int minimumLenght, string password, List<InvalidationResult> invalidationResults)
	{
		if (minimumLenght > 0 && !MinimumNumberOfCharacters(minimumLenght, password))
		{
			invalidationResults.Add(InvalidationResult.NotEnoughPasswordLenght);
		}
	}
	
	private static bool MinimumNumberOfCharacters(int minimumLenght, string password)
	{
		return password.Length >= minimumLenght;
	}
}