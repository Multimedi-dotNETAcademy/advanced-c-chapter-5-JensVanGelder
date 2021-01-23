using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Chapter1
{
    class Rabbit:Mammal
    {
        public int CarrotsEaten { get; set; }

        public override string Move()
        {
            return "Hoppity Hop";
        }
        public override string ShowInfo()
        {
            string add = $", Has eaten {CarrotsEaten} carrots";
            return base.ShowInfo() +add;
        }

        public override string MakeSound()
        {
            return "Whatever sound a rabbit makes";
        }
    }
}
