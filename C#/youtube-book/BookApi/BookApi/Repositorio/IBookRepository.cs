using BookApi.Model;

namespace BookApi.Repositorio
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> Get();

        public Task<Book> Get(int Id);

        public Task<Book> Create(Book book);

        public Task Update(Book book);

        public Task Delete(int Id);
    }
}
