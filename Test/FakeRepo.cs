using Core;

namespace Unit
{
    public class FakeRepo
    {
        [Fact]
        public async void WhenGivenANewBook_Save_AssignsAnId()
        {
            FakeRepository sut = new();
            Book book = new()
            {
                Author = "dummyAuthor",
                Title = "dummyTitle",
                PublicationDate = DateTime.UtcNow.AddDays(-1)
            };
            var id = await sut.Save(book);
            Assert.Equal(0, id);
        }

        [Fact]
        public async void WhenGivenSeveralBooks_Save_AssignsIdsSequentially()
        {
            FakeRepository sut = new();
            Book book1 = new() { Author = "author1", Title = "title1", PublicationDate = DateTime.UtcNow.AddDays(-1) };
            Book book2 = new() { Author = "author2", Title = "title2", PublicationDate = DateTime.UtcNow.AddDays(-2) };
            var id1 = await sut.Save(book1);
            var id2 = await sut.Save(book2);
            Assert.Equal(id2, id1 + 1);
        }
    }
}
