using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string ScaleColor { get; set; }
        public bool CanCamo { get; set; }
        public int Length { get; set; }
        public bool CanRegen { get; set; }
    }
}
