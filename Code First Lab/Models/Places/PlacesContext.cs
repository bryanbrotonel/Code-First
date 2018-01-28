using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_Lab.Models.Places
{
    public class PlacesContext: DbContext
    {
        public PlacesContext() : base("DefaultConnection")
        {}

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}