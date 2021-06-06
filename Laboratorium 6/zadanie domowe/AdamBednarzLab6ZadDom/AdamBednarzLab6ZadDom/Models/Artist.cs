using System;
using System.ComponentModel.DataAnnotations;

namespace AdamBednarzLab6ZadDom.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
    }
}
