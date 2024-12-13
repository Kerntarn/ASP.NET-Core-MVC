using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Ticket{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Movie's Name")]
        public string Movie { get; set; }
        [DisplayName("Movie's Price per ticket")]
        [Range(0, 1000)]
        public int Price { get; set; }
    }
}