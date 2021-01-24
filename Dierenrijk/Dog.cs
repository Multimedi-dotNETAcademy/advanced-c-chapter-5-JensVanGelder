namespace AdvancedC_Chapter1
{
    internal class Dog : Mammal
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
            return base.ShowInfo() + add;
        }
    }
}