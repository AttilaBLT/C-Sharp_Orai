namespace LoL.UI.Extensions;

public static class ObjectExtensions
{
    public static ModelValidationResult Validate<T>(this T instance) where T : class
    {
        ValidationContext context = new ValidationContext(instance);
        List<ValidationResult> validationResults = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(instance, context, validationResults, true);

        return new ModelValidationResult(validationResults);
    }

    public class ModelValidationResult
    {
        public bool isValid
        {
            get
            {
                return !Errors.Any();
            }
        }

        public Dictionary<string, string> Errors { get; private set; } = new Dictionary<string, string>();

        public ModelValidationResult(IEnumerable<ValidationResult> validationResults)
        {
            foreach (var validationResult in validationResults)
            {
                Errors.Add(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }
        }
    }
}
