using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IRepository
    {
        Task<int> Save(Book book);
        Task<Book> Get(int id);
        Task<IEnumerable<Book>> Get();
        Task<bool> Delete(int id);
    }

    public class FakeRepository : IRepository
    {
        private ConcurrentDictionary<int, Book> data = new();

        public Task<int> Save(Book book)
        {
            int nextId;
            var isSuccess = false;
            do
            {
                nextId = data.Count;
                isSuccess = data.TryAdd(nextId, book);
            }
            while (isSuccess == false);
            return Task.FromResult(nextId);
        }

        public Task<Book> Get(int id)
        {
            if (data.ContainsKey(id))
                return Task.FromResult(data[id]);
            else
                return Task.FromResult<Book>(default);
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
