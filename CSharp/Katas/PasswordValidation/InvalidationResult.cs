namespace Katas.PasswordValidation;

public enum InvalidationResult
{
	NotEnoughPasswordLenght,
	DoesNotContainCapitalLetter,
	DoesNotContainLowerCaseLetter,
	DoesNotContainNumbers,
	DoesNotContainUnderscore
}