using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab4ZadDom.Models
{
    public class BloodViewModel
    {
        /// <summary>
        /// Tworzenie modelu grupy krwi
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="percentRhPlus"></param>
        /// <param name="percentRhMinus"></param>
        public BloodViewModel(string type, string description, decimal percentRhPlus, decimal percentRhMinus)
        {
            Type = type;
            Description = description;
            PercentRhPlus = percentRhPlus;
            PercentRhMinus = percentRhMinus;
        }

        public string Type { get; set; }

        public string Description { get; set; }

        public decimal PercentRhPlus { get; set; }

        public decimal PercentRhMinus { get; set; }
    }
}
