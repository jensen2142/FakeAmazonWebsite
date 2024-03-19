
namespace Mission11_Hermansen.Models
{
    public class EFAmazonRepository : IAmazonRepository
    {
        private AmazonContext _context;
        public EFAmazonRepository(AmazonContext temp)
        {
            _context = temp;
        }
        public IQueryable<Books> Books => _context.Books;
    }
}
