namespace Katalyst.PasswordValidation;

public class ValidationResult
{
	public bool IsValid { get; set; }
	public List<InvalidationResult> InvalidationResults { get; set; }
}