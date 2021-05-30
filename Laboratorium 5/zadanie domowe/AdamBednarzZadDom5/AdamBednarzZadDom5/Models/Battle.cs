using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzZadDom5.Models
{
    public class Battle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Rok")]
        public int Year { get; set; }

        [Required]
        public int AgeId { get; set; }

        [ForeignKey("AgeId")]
        [Display(Name = "Epoka")]
        public Age Age { get; set; }

        [Required]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        [Display(Name = "Przeciwnik")]
        public Country Country { get; set; }

        [Required]
        public int CommanderId { get; set; }

        [ForeignKey("CommanderId")]
        [Display(Name = "Dowódca")]
        public Commander Commander { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
    }
}
