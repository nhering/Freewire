using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Freewire.Models
{
    public class EquipmentModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Manufacturer name is required")]
        [Display(Name = "Manufacturer")]
        public string Make { get; set; }
        public string Model { get; set; }
        [Display(Name = "Max Distance (miles)")]
        public double Distance { get; set; }
        [Display(Name = "Max Bandwidth (Mbps)")]
        public int Bandwidth { get; set; }
        [Required]
        public License? License { get; set; }
        [Required(ErrorMessage = "Cost is required")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Cost { get; set; }
    }

    public enum License
    {
        [Display(Name = "Required")]
        Required,
        [Display(Name = "Not Required")]
        NotRequired,
        [Display(Name = "N/A")]
        NotApplicable
    }
}