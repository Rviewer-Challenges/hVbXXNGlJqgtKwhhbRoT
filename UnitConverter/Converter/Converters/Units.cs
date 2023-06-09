using Converter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Converters
{
    public class BasicUnit : IUnit
    {
        public Units unitType { get; set; }
        public double relationShip { get; set; }
        public string descriptor { get; set; }
    }

    #region DISTANCES

    public class Centimeter : BasicUnit
    {
        public Centimeter() 
        {
            unitType = Units.Centimeter;
            relationShip = 0.01;
            descriptor = "cm";
        }
    }

    public class Meter : BasicUnit
    {
        public Meter() 
        {
            unitType = Units.Meter;
            relationShip = 1;
            descriptor = "m";
        }
    }

    public class Kilometer : BasicUnit
    {
        public Kilometer() 
        {
            unitType = Units.Kilometer;
            relationShip = 1000;
            descriptor = "km";
        }
    }
    #endregion


    #region WEIGHTS

    public class Miligrams : BasicUnit
    {
        public Miligrams() 
        {
            unitType = Units.Miligrams;
            relationShip = 0.001;
            descriptor = "mg";
        }
    }
    public class Grams : BasicUnit
    {
        public Grams() 
        {
            unitType = Units.Grams;
            relationShip = 1;
            descriptor = "g";
        }
    }
    public class Packets : BasicUnit
    {
        public Packets() 
        {
            unitType = Units.Packets;
            relationShip = 72.5;
            descriptor = "ю";
        }
    }
    public class Kilograms : BasicUnit
    {
        public Kilograms() 
        {
            unitType = Units.Kilograms;
            relationShip = 1000;
            descriptor = "Kg";
        }
    }



    #endregion



}
