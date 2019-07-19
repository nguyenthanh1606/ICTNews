using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITC.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Skype { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Zalo { get; set; }
        public string Facebook { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}