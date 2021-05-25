﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab5.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public int YearOfRelease { get; set; }

        [Required]
        public int DirectorId { get; set; }

        [ForeignKey("DirectorId")]
        public Director Director { get; set; }
    }
}
