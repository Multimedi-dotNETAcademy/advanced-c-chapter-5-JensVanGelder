namespace AdvancedC_Chapter1
{
    internal abstract class Mammal : Animal
    {
        public string HairColour { get; set; }
        public bool IsPregnant { get; set; }

        public void GiveBirth()
        {
            //Give birth
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $", Hair Colour: {HairColour}, {(IsPregnant ? "Is Pregnant" : "")}";
        }
    }
}