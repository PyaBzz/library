using Core;
using Test;

namespace Unit
{
    public class Book_PublishedOn : Book_Test
    {
        [Fact]
        public void WhenPublishedTomorrow_IsInvalid()
        {
            Book sut = new Book(dummyTitle, dummyAuthor, tomorrow);
            ModelStateTester.Do(sut, false);
        }

        [Fact]
        public void WhenPublishedInvalid_GivesTheRightValidationMessage()
        {
            Book sut = new Book(dummyTitle, dummyAuthor, tomorrow);
            ModelStateTester.Do(sut, false, Message.invalid_publication_date);
        }

        [Fact]
        public void WhenPublishedYesterday_IsValid()
        {
            Book sut = new Book(dummyTitle, dummyAuthor, yesterday);
            ModelStateTester.Do(sut, true);
        }
    }
}
