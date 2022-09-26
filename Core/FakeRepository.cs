using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal interface IRepository
    {
        Task<int> Save(Book book);
        Task<bool> Delete(int id);
        Task<Book> Get(int id);
        Task<IEnumerable<Book>> Get();
    }

    internal class FakeRepository : IRepository
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
