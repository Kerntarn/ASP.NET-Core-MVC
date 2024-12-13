using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Ticket{
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please Enter a Movie's Name.")]
        [DisplayName("Movie's Name")]
        public string Movie { get; set; }
        [DisplayName("Movie's Price per ticket")]
        [Range(0, 1000, ErrorMessage = "Invalid or Too Expensive Price.")]
        public int Price { get; set; }
    }
}