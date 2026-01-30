using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_50.E_Num
{

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public class Coustomer
    {
        public string name { get; set; }
        public Gender gender { get; set; } 
    }
}
