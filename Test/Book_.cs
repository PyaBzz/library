using Core;
using System.ComponentModel.DataAnnotations;

namespace Unit
{
    public class Book_
    {
        [Fact]
        public void WhenTitleIsNull_BecomesInvalid()
        {
            Book sut = new Book(null, null, dummyAuthor, yesterday);
            Test_Required_Field(sut);
        }

        [Fact]
        public void WhenTitleIsEmpty_BecomesInvalid()
        {
            Book sut = new Book(null, empty, dummyAuthor, yesterday);
            Test_Required_Field(sut);
        }

        [Fact]
        public void WhenTitleIsSpace_BecomesInvalid()
        {
            Book sut = new Book(null, space, dummyAuthor, yesterday);
            Test_Required_Field(sut);
        }

        [Fact]
        public void WhenTitleIsEmpty_GivesTheRightValidationMessage()
        {
            Book sut = new Book(null, empty, dummyAuthor, yesterday);
            Test_Required_Field(sut, false, Message.required_title);
        }

        //==============================  Private Stuff  ==============================
        private readonly string empty = string.Empty;
        private const string space = " ";
        private const string dummyTitle = "dummyTitle";
        private const string dummyAuthor = "dummyAuthor";
        private readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);
        private readonly DateTime tomorrow = DateTime.UtcNow.AddDays(+1);


        private void Test_Required_Field(Book sut, bool shouldBeValid = false, string message = null)
        {
            ValidationContext ctx = new(sut);
            List<ValidationResult> resultSet = new();
            var isValid = Validator.TryValidateObject(sut, ctx, resultSet);
            Assert.Equal(shouldBeValid, isValid);
            if (shouldBeValid == false && message != null)
            {
                Assert.Equal(message, resultSet.First().ErrorMessage);
            }
        }

        private static class Message
        {
            public const string required_title = "The Title field is required.";
        };
    }
}
