using System.ComponentModel.DataAnnotations;

namespace Mission11_Hermansen.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public string Classification { get; set; } = string.Empty;
        public int PageCount { get; set; } = int.MaxValue;
        public decimal Price { get; set; } = decimal.MaxValue;

    }
}
