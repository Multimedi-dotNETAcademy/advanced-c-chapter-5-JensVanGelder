using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Chapter1
{
    class Reptile:Animal
    {
        public string ScaleType { get; set; }
        public int ScaleAmount { get; set; }

        public override string ShowInfo()
        {
            string add = $", Scale type: {ScaleType}, Number of scales: {ScaleAmount}";
            return base.ShowInfo()+add;
        }
    }
}
