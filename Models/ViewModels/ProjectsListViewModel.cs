namespace Mission11_Hermansen.Models.ViewModels
{
    public class ProjectsListViewModel
    {
        public IQueryable<Project> Projects { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
