﻿using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotential : BaseUnit
    {

        public ElectricPotential() { }
        public ElectricPotential(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotential(UnknownUnit value) : base(value) { }

        public ElectricPotential(UnknownUnit value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricPotential From(double value, ElectricPotentialUnit unit) => new(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricPotential ToUnit(ElectricPotentialUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotential Zero => new(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotential(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricPotential(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
