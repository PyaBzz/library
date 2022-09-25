using Core;
using System.ComponentModel.DataAnnotations;

namespace Test
{
    internal static class ModelStateTester
    {
        internal static void Do(Book sut, bool shouldBeValid = false, string message = null)
        {
            ValidationContext ctx = new(sut);
            List<ValidationResult> resultSet = new();
            var isValid = Validator.TryValidateObject(sut, ctx, resultSet, true);
            Assert.Equal(shouldBeValid, isValid);
            if (shouldBeValid == false && message != null)
            {
                Assert.Equal(message, resultSet.First().ErrorMessage);
            }
        }
    }
}
