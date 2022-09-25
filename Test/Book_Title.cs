using Core;
using Test;

namespace Unit
{
    public class Book_Title : Book_Test
    {
        [Fact]
        public void WhenTitleIsNull_BecomesInvalid()
        {
            Book sut = new Book(null, dummyAuthor, yesterday);
            ModelStateTester.Do(sut);
        }

        [Fact]
        public void WhenTitleIsEmpty_BecomesInvalid()
        {
            Book sut = new Book(empty, dummyAuthor, yesterday);
            ModelStateTester.Do(sut);
        }

        [Fact]
        public void WhenTitleIsSpace_BecomesInvalid()
        {
            Book sut = new Book(space, dummyAuthor, yesterday);
            ModelStateTester.Do(sut);
        }

        [Fact]
        public void WhenTitleIsInvalid_GivesTheRightValidationMessage()
        {
            Book sut = new Book(empty, dummyAuthor, yesterday);
            ModelStateTester.Do(sut, false, Message.required_title);
        }

        [Fact]
        public void WhenTitleIsNonEmpty_IsValid()
        {
            Book sut = new Book(dummyTitle, dummyAuthor, yesterday);
            ModelStateTester.Do(sut, true);
        }
    }
}
