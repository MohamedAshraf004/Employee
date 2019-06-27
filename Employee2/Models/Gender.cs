using System.ComponentModel.DataAnnotations;

namespace Employee2.Models
{
    public class Gender
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string GenderName { get; set; }
    }
}