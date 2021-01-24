namespace Hospital
{
    internal class InsuredPatient : Patient
    {
        public override decimal CalculateCost()
        {
            return base.CalculateCost() - (base.CalculateCost() / 10);
        }
    }
}