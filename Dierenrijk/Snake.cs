namespace AdvancedC_Chapter1
{
    internal class Snake : Reptile
    {
        public bool IsVenomous { get; set; }

        public override string Move()
        {
            return "Slither";
        }

        public override string MakeSound()
        {
            return "ssssssss";
        }

        public override string ShowInfo()
        {
            string add = $", { (IsVenomous ? "Is venomous" : " Doesn't have venom") }";
            return base.ShowInfo() + add;
        }
    }
}