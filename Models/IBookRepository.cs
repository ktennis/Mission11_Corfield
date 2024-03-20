namespace Mission11_Corfield.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }  
    }
}
