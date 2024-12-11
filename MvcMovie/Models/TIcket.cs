using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Ticket{
        [Key]
        public string Id { get; set; }
        
        [Required]
        public string Movie { get; set; }
        public int Price { get; set; }
    }
}