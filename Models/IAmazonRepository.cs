namespace Mission11_Hermansen.Models
{
    public interface IAmazonRepository
    {
        public IQueryable<Books> Books { get; }
    }
}
