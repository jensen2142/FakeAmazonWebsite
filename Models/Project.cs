using System.ComponentModel.DataAnnotations;

namespace Mission11_Hermansen.Models
{
    public class Project
    {
        [Key]
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public string? ClassificationOrCategory { get; set; }
        public int? NumberOfPages { get; set; }
        public decimal? Price { get; set; }

    }
}
