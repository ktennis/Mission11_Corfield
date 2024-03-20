namespace Mission11_Corfield.Model
{
    public interface IBooksRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
