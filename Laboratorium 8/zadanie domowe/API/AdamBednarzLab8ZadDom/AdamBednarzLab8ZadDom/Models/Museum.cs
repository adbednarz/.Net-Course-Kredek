using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdamBednarzLab8ZadDom.Models
{
    public class Museum
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Rok założenia")]
        public int Year { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
    }
}
