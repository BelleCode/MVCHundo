using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHundo.Models
{
    public class HundoNumbers
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        //lists cannot be NULL
        public List<string> Results { get; set; } = new List<string>();
    }
}