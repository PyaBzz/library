namespace Test
{
    public abstract class Book_Test
    {
        protected const string empty = "";
        protected const string space = " ";
        protected const string dummyTitle = "dummyTitle";
        protected const string dummyAuthor = "dummyAuthor";

        protected readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);
        protected readonly DateTime tomorrow = DateTime.UtcNow.AddDays(+1);

        protected static class Message
        {
            public const string required_title = "The Title field is required.";
            public const string invalid_publication_date = "PublicationDate for Book needs to be a valid date in the past.";
        };
    }
}
