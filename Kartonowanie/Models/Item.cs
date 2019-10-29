using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartonowanie.Models
{
    public class Item: Dimensions
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }
        public decimal Objetosc { get { return W * H * L; } }
        public string Name { get; set; }
    }
}
