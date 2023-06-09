using Converter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Converters
{
    public class BasicConverter : IConverter
    {
        public IUnit From { get; set; }
        public IUnit To { get ; set ; }
        public Units masterUnit { get; set; }
        public List<IUnit> AvailableUnits { get; set ; }

        public void SetUnitsListRelative(int fromIdx, int toIdx) 
        {
            From = AvailableUnits[fromIdx];
            To = AvailableUnits[toIdx];
        }

        public double Calculate(double valueToConvert)
        {
            double toRet = 0;
            toRet = (valueToConvert * From.relationShip) / To.relationShip;
            return toRet;
        }
    }

    public class Converters : BasicConverter
    {
        public Converters() 
        {
            AvailableUnits = new List<IUnit>() { new Centimeter(), new Meter(), new Kilometer()};
            masterUnit = Units.Meter;
        }
    }

    public class Weight : BasicConverter
    {
        public Weight() 
        {
            AvailableUnits = new List<IUnit>() { new Miligrams(), new Grams(), new Packets(), new Kilograms()};
            masterUnit = Units.Grams;
        }

    }


}
