using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzZadDom5.Models
{
    public class Age
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Umowny początek")]
        public string YearOfStart { get; set; }

        [Required]
        [Display(Name = "Umowny koniec")]
        public string YearOfEnd { get; set; }

        public ICollection<Battle> Battles { get; set; }
    }
}
