using Core;
using System.ComponentModel.DataAnnotations;
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
        public void WhenPublishedYesterday_IsValid()
        {
            Book sut = new Book(dummyTitle, dummyAuthor, yesterday);
            ModelStateTester.Do(sut, true);
        }
    }
}
