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

        /// <summary>
        /// Selects From and To units dependding o IUnit list idx.
        /// </summary>
        /// <param name="fromIdx">AvailableUnits idx used for From</param>
        /// <param name="toIdx">AvailableUnits idx used for To<</param>
        public void SetUnitsListRelative(int fromIdx, int toIdx) 
        {
            From = AvailableUnits[fromIdx];
            To = AvailableUnits[toIdx];
        }

        /// <summary>
        /// Basic calculation using arithmetic proportion depending From and To selections.
        /// </summary>
        /// <param name="valueToConvert">value to convert</param>
        /// <returns>converted value</returns>
        public virtual double Calculate(double valueToConvert)
        {
            double toRet = 0;
            toRet = (valueToConvert * From.relationShip) / To.relationShip;
            return toRet;
        }
        /// <summary>
        /// Arithmetic proportion calculation applying offsets, used for temperature conversion
        /// </summary>
        /// <param name="valueToConvert"></param>
        /// <param name="fromOffset">offset to master unit of From param</param>
        /// <param name="toOffset">offset to master unit of To param</param>
        /// <returns>converted value</returns>
        public virtual double Calculate(double valueToConvert, double fromOffset,double toOffset)
        {
            valueToConvert = this.Calculate(valueToConvert) + (toOffset - fromOffset) ;
            return valueToConvert;
        }
    }

    #region CONVERTERS
    public class Temperature : BasicConverter 
    {
        public Temperature() 
        {
            AvailableUnits = new List<IUnit>() { new Celsius(), new Kelvin(), new Farenheit() };
            masterUnit = Units.Celsius;
        
        }
    
        public override double Calculate(double ValueToConvert) 
        {
            return base.Calculate(ValueToConvert);
        }
    
    }


    public class Distance : BasicConverter
    {
        public Distance() 
        {
            AvailableUnits = new List<IUnit>() {new Milimeter(), new Centimeter(), new Meter(),
                new Kilometer(),new Feet(),new Inches(),new Yard(),new Mille(),new NauticMille(),
                new YearLight(),new HappyStick(), new MoonDistance(), new BasketCourt(), new SoccerField()
            };
            masterUnit = Units.Meter;
        }
    }

    public class Weight : BasicConverter
    {
        public Weight() 
        {
            AvailableUnits = new List<IUnit>()
            {
                new Miligrams(),new Centigrams(),new Decigrams(), new Grams(),
                new Decagrams(),new Hectograms(), new Packets(), new Kilograms(),
                new Ton(),new Ounze(), new TroyOunze(), new Pound(),new EiffelTower(),
                new PisaTower() ,new GreatPiramyd(), new AAABattery(), new EuroCoin(),
                new Human(),new Mars(),new Earth(),new Sun(),new Soul()
            };
            masterUnit = Units.Grams;
        }
    }


    public class Speed : BasicConverter
    {
        public Speed() 
        {
            AvailableUnits = new List<IUnit>()
            {
                new MetersPerSecond(),new KilometerPerHour(),new MilePerHour(),new Knot(),new FeetPerSecond(),
                new KilometerPerSecond(), new MicroMeterPerSecond(), new NauticMillePerHour(), new HumanRun(),
                new Leopard(),
            };
            masterUnit = Units.MetersPerSecond;
        }
    }
    #endregion

}
