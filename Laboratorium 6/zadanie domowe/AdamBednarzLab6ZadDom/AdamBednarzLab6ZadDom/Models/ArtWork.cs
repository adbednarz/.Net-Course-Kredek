using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AdamBednarzLab6ZadDom.Models
{
    public class ArtWork
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Rok powstania")]
        public int Year { get; set; }

        [Required]
        public int MuseumId { get; set; }

        [ForeignKey("MuseumId")]
        [Display(Name = "Muzeum")]
        [JsonIgnore]
        public Museum Museum { get; set; }

        [Required]
        public int ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        [Display(Name = "Artysta")]
        [JsonIgnore]
        public Artist Artist { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
    }
}
