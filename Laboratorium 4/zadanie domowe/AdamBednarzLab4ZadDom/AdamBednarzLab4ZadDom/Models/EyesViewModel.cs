using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab4ZadDom.Models
{
    public class EyesViewModel
    {
        /// <summary>
        /// Tworzenie modelu koloru oczu
        /// </summary>
        /// <param name="color"></param>
        /// <param name="percent"></param>
        /// <param name="description"></param>
        public EyesViewModel(string color, decimal percent, string description)
        {
            Color = color;
            Percent = percent;
            Description = description;
        }

        public string Color { get; set; }

        public decimal Percent { get; set; }

        public string Description { get; set; }
    }
}
