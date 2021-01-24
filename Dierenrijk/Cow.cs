namespace AdvancedC_Chapter1
{
    internal class Cow : Mammal
    {
        public bool HasBell { get; set; }
        public string Spots { get; set; }

        public override string Move()
        {
            if (HasBell == true)
            {
                return "ding ding ding";
            }
            else
            {
                return "clopclop";
            }
        }

        public override string ShowInfo()
        {
            string add = $", {(HasBell ? "Has a Bell" : "")}, Has {Spots} kind of spots";
            return base.ShowInfo() + add;
        }

        public override string MakeSound()
        {
            return "MOO";
        }
    }
}