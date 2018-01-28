using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Lab.Models.Places
{
    public class Province
    {
        [Key]
        public string provinceCode { get; set; }
        public string provinceName { get; set; }
        public List<City> cities { get; set; }

    }
}