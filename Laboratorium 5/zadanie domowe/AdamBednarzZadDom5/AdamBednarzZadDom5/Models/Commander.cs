using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzZadDom5.Models
{
    public class Commander
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

        public ICollection<Battle> Battles { get; set; }
    }
}
