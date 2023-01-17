namespace Katas.PasswordValidation;

public class ValidationResult
{
	public bool IsValid { get; set; }
	public List<InvalidationResult> InvalidationResults { get; set; }
}