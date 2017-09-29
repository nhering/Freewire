using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Freewire.Models
{
    public class Company
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public state? State { get; set; }
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }
        [DataType(DataType.Url)]
        public string WebSite { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public virtual ICollection<CompanyCategory> Category { get; set; }
    }

    public enum state
    {
        [Display(Name = "Alabama")]
        AL,
        [Display(Name = "Alaska")]
        AK,
        [Display(Name = "Arizona")]
        AZ,
        [Display(Name = "Arkansas")]
        AR,
        [Display(Name = "California")]
        CA,
        [Display(Name = "Colorado")]
        CO,
        [Display(Name = "Connecticut")]
        CT,
        [Display(Name = "Delaware")]
        DE,
        [Display(Name = "District of Columbia")]
        DC,
        [Display(Name = "Florida")]
        FL,
        [Display(Name = "Georgia")]
        GA,
        [Display(Name = "Hawaii")]
        HI,
        [Display(Name = "Idaho")]
        ID,
        [Display(Name = "Illinois")]
        IL,
        [Display(Name = "Indiana")]
        IN,
        [Display(Name = "Iowa")]
        IA,
        [Display(Name = "Kansas")]
        KS,
        [Display(Name = "Kentucky")]
        KY,
        [Display(Name = "Louisiana")]
        LA,
        [Display(Name = "Maine")]
        ME,
        [Display(Name = "Maryland")]
        MD,
        [Display(Name = "Massachusetts")]
        MA,
        [Display(Name = "Michigan")]
        MI,
        [Display(Name = "Minnesota")]
        MN,
        [Display(Name = "Mississippi")]
        MS,
        [Display(Name = "Missouri")]
        MO,
        [Display(Name = "Montana")]
        MT,
        [Display(Name = "Nebraska")]
        NE,
        [Display(Name = "Nevada")]
        NV,
        [Display(Name = "New Hampshire")]
        NH,
        [Display(Name = "New Jersey")]
        NJ,
        [Display(Name = "New Mexico")]
        NM,
        [Display(Name = "New York")]
        NY,
        [Display(Name = "North Carolina")]
        NC,
        [Display(Name = "North Dakota")]
        ND,
        [Display(Name = "Ohio")]
        OH,
        [Display(Name = "Oklahoma")]
        OK,
        [Display(Name = "Oregon")]
        OR,
        [Display(Name = "Pennsylvania")]
        PA,
        [Display(Name = "Rhode Island")]
        RI,
        [Display(Name = "South Carolina")]
        SC,
        [Display(Name = "South Dakota")]
        SD,
        [Display(Name = "Tennessee")]
        TN,
        [Display(Name = "Texas")]
        TX,
        [Display(Name = "Utah")]
        UT,
        [Display(Name = "Vermont")]
        VT,
        [Display(Name = "Virginia")]
        VA,
        [Display(Name = "Washington")]
        WA,
        [Display(Name = "West Virginia")]
        WV,
        [Display(Name = "Wisconsin")]
        WI,
        [Display(Name = "Wyoming")]
        WY,

    }
}