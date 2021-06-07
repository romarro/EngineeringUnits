﻿using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class MassFlow : BaseUnit
    {

        public MassFlow()
        {
            Name = "MassFlow";
        }


        public MassFlow(double value, MassFlowUnit energyUnit) : this()
        {

            Unit = energyUnit.Unit;
            ValueLocalUnit = (decimal)value;
        }

        public double As(MassFlowUnit energyUnit)
        {
            //return ToTheOutSide(energyUnit.Unit);
            return (double)ToTheOutSide(energyUnit.Unit);
        }

        //Every units needs this
        public static implicit operator MassFlow(UnknownUnit Unit)
        {
            MassFlow local = new MassFlow(0, MassFlowUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}