using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapProject.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }
        public int GeographicalProduct { get; set; }
        public int CenturyBrandProduct { get; set; }
    }
}
