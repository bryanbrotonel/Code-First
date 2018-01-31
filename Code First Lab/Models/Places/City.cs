using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Lab.Models.Places
{
    public class City
    {
        [Key]
        public int cityID { get; set; }

        [Display(Name = "City")]
        public string cityName { get; set; }

        public int population { get; set; }

        [Display(Name = "Province Code")]
        public string provinceCode { get; set; }

    }
}