namespace Mission11_Hermansen.Models
{
    public interface IAmazonRepository
    {
        public IQueryable<Project> Projects { get; }
    }
}
