using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Ticket{
        [Key]
        public string Id { get; set; }
        
        [Required]
        [DisplayName("Movie's Name")]
        public string Movie { get; set; }
        [DisplayName("Movie's Price per ticket")]
        [Range(0, 100)]
        public int Price { get; set; }
    }
}