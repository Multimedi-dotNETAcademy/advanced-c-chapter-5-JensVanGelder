using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Chapter1
{
    class Dog:Mammal
    {
        public int BonesBurried { get; set; }
        public override string MakeSound()
        {
            return "BarkBark";
        }
        public override string Move()
        {
            return "Runs after the mailman.";
        }
        public override string ShowInfo()
        {
            string add = $", Has buried {BonesBurried} bones";
            return base.ShowInfo()+add;
        }
    }
}
