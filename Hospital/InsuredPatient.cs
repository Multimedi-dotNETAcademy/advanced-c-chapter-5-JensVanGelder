﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class InsuredPatient:Patient
    {
        public override decimal CalculateCost()
        {
            return base.CalculateCost()-(base.CalculateCost()/10);
        }
    }
}
