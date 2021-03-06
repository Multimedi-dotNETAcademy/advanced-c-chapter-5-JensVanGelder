﻿namespace Hospital
{
    internal class Patient
    {
        public string Name { get; set; }
        public int HoursInHospital { get; set; }

        public virtual decimal CalculateCost()
        {
            return 50 + (20 * HoursInHospital);
        }

        public string ShowInfo()
        {
            return $"Patient: {Name} has been in the hospital for {HoursInHospital} hours. Total cost will be: {CalculateCost()}.";
        }
    }
}