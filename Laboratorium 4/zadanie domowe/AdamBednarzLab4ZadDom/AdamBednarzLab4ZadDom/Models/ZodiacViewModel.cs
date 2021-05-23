using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab4ZadDom.Models
{
    public class ZodiacViewModel
    {
        /// <summary>
        /// Tworzenie modelu znaku zodiaku
        /// </summary>
        /// <param name="sign"></param>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="photo"></param>
        public ZodiacViewModel(string sign, string date, string description, string photo)
        {
            Sign = sign;
            Date = date;
            Description = description;
            Photo = photo;
        }

        public string Sign { get; set; }

        public string Date { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }
    }
}
