﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class EnergyUnit : Enumeration
    {


        public static EnergyUnit SI = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");

        public static EnergyUnit Millijoule = new EnergyUnit(MassUnit.Gram, LengthUnit.SI, DurationUnit.SI, "mJ");
        public static EnergyUnit Joule = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");
        public static EnergyUnit Kilojoule = new EnergyUnit(MassUnit.Tonne, LengthUnit.SI, DurationUnit.SI, "kJ");
        public static EnergyUnit Megajoule = new EnergyUnit(MassUnit.Kilotonne, LengthUnit.SI, DurationUnit.SI, "MJ");
        public static EnergyUnit Gigajoule = new EnergyUnit(MassUnit.Megatonne, LengthUnit.SI, DurationUnit.SI, "GJ");

        public static EnergyUnit WattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Wh", 3600m);
        public static EnergyUnit WattDay = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Wd", 24 * 3600m);

        public static EnergyUnit KilowattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "kWh", 3600m * 1e3m);
        public static EnergyUnit KilowattDay = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "kWd", 24 * 3600m * 1e3m);
        public static EnergyUnit MegawattDay = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "MWd", 24 * 3600m * 1e6m);
        public static EnergyUnit MegawattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "MWh", 3600m * 1e6m);
        public static EnergyUnit GigawattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "GWh", 3600m * 1e9m);
        public static EnergyUnit GigawattDay = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "GWd", 24*3600m * 1e9m);

        public static EnergyUnit TerawattDay = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "TWd",  24 * 3600m * 1e12m);
        public static EnergyUnit TerawattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "TWh", 3600m * 1e12m);

        public static EnergyUnit BritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static EnergyUnit KilobritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "kBTU", 1055.06m * 1e3m);
        public static EnergyUnit MegabritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "MBTU", 1055.06m * 1e6m);
        public static EnergyUnit GigabritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "GBTU", 1055.06m * 1e9m);

        public static EnergyUnit Calorie = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static EnergyUnit Kilocalorie = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "kcal", 4.184m * 1e3m);
        public static EnergyUnit Megacalorie = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Mcal", 4.184m * 1e6m);

        public static EnergyUnit ElectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);
        public static EnergyUnit KiloelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "keV", 0.0000000000000000001602176565m * 1e3m);
        public static EnergyUnit MegaelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "MeV", 0.0000000000000000001602176565m * 1e6m);
        public static EnergyUnit GigaelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "GeV", 0.0000000000000000001602176565m * 1e9m);
        public static EnergyUnit TeraelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "TeV", 0.0000000000000000001602176565m * 1e12m);

        public static EnergyUnit FootPound = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "ft·lb", 1.3558179483314004m);

        public static EnergyUnit DecathermEc = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (E.C.)", 1055055852.62m);
        public static EnergyUnit DecathermImperial = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (imp.)",  1055055852.57348m);
        public static EnergyUnit DecathermUs = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (U.S.)",        1054804000.0m);

        public static EnergyUnit ThermEc = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (E.C.)", 105506000m);
        public static EnergyUnit ThermImperial = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (imp.)", 105505585.257348m);
        public static EnergyUnit ThermUs = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (U.S.)", 105480400.00m);

        public static EnergyUnit Erg = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "erg", 1e-7m);
        public static EnergyUnit HorsepowerHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "hp·h", 2.6845195377e6m);




        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Energy";

            //kg*m2*s-2
            Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit);

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }

            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", 1, correction);
            }


        }


        public static IEnumerable<EnergyUnit> List()
        {
            return new[] { BritishThermalUnit, Calorie, DecathermEc, DecathermImperial, DecathermUs, ElectronVolt, Erg, FootPound, GigabritishThermalUnit, GigaelectronVolt, Gigajoule, GigawattDay, GigawattHour, HorsepowerHour, Joule, KilobritishThermalUnit, Kilocalorie, KiloelectronVolt, Kilojoule, KilowattDay, KilowattHour, MegabritishThermalUnit, Megacalorie, MegaelectronVolt, Megajoule, MegawattDay, MegawattHour, Millijoule, TeraelectronVolt, TerawattDay, TerawattHour, ThermEc, ThermImperial, ThermUs, WattDay, WattHour, };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}