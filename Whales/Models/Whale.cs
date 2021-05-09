using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Whales.Models
{
    public class Whale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AverageSize { get; set; }
        public string Description { get; set; }
        public Diet Diet { get; set;  }
    }
}
