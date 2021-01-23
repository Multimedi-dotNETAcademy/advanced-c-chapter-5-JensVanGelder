using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Chapter1
{
    class Iguana:Reptile
    {
        public int TongueLength { get; set; }
        public override string MakeSound()
        {
            return "iguana iguana";
        }
        public override string ShowInfo()
        {
            string add = $", Has a tonuge of {TongueLength} cm";
            return base.ShowInfo()+add;
        }
        public override string Move()
        {
            return "Iguana moving";
        }
    }
}
