namespace Mission11_Hermansen.Models.ViewModels
{
    public class ProjectsListViewModel
    {
        public IQueryable<Books> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
