using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApp.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Author { get; set; }
        public string? Genre { get; set; }
    }
}
