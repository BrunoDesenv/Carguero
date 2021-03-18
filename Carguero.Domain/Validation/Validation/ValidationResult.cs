using System.Collections.Generic;
using System.Linq;

namespace Carguero.Domain.Validation.Validation
{
    public class ValidationResult
    {
        public string Message { get; set; }
        public bool IsValid { get => !Error.Any(); }
        public IEnumerable<ValidationError> Error { get; private set; }

        public ValidationResult()
        {
            Error = new ValidationError[] { };
        }

        public void Add(ValidationError error)
        {
            var list = new List<ValidationError>(Error) { error };
            SetErrors(list);
        }

        public void Add(params ValidationResult[] validationResults)
        {
            var list = new List<ValidationError>(Error);
            foreach (var validation in validationResults)
                list.AddRange(validation.Error);

            SetErrors(list);
        }

        public void Remove(ValidationError error)
        {
            var list = new List<ValidationError>(Error);
            list.Remove(error);
            SetErrors(list);
        }

        private void SetErrors(List<ValidationError> errors)
        {
            Error = errors;

            if (!IsValid)
                Message = errors[0].Message;
        }
    }
}
