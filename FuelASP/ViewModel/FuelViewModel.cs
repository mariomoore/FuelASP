using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FuelASP.ViewModel
{
    public class FuelViewModel
    {
        [Required]
        [DisplayName("Ilość spalonego paliwa [l]")]
        public double FuelBurned { get; set; }
        [Required]
        [DisplayName("Przejechany dystans [km]")]
        public double Distance { get; set; }
        [DisplayName("Średnie zużycie paliwa [l/km]")]        
        public double AverageFuelBurn { get; set; }
    }
}