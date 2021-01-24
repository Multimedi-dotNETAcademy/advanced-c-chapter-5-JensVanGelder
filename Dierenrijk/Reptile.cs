namespace AdvancedC_Chapter1
{
    internal class Reptile : Animal
    {
        public string ScaleType { get; set; }
        public int ScaleAmount { get; set; }

        public override string ShowInfo()
        {
            string add = $", Scale type: {ScaleType}, Number of scales: {ScaleAmount}";
            return base.ShowInfo() + add;
        }
    }
}