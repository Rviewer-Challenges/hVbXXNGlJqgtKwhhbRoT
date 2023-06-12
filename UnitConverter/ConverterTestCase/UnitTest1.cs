using Converter;
using Converter.Converters;
using Converter.Enums;
using NUnit.Framework;
using System.Collections.Generic;

namespace ConverterTestCase
{
    public class Tests
    {
        List<IConverter> converters = new List<IConverter>();

        [SetUp]
        public void Setup()
        {
            converters = new List<IConverter>() { new Distance(), new Speed(), new Temperature(), new Weight() };
        }

        [Test]
        public void DistanceTest()
        {
            Distance distanceConverter = (Distance)converters[0];
            distanceConverter.From = distanceConverter.AvailableUnits[0];
            distanceConverter.To = distanceConverter.AvailableUnits[0];
            Assert.AreEqual(200,distanceConverter.Calculate(200));
            Assert.AreEqual("mm",distanceConverter.From.descriptor);

            distanceConverter.From = distanceConverter.AvailableUnits[4];
            distanceConverter.To = distanceConverter.AvailableUnits[1];
            Assert.AreEqual("ft",distanceConverter.From.descriptor);
            Assert.AreEqual("cm",distanceConverter.To.descriptor);
            Assert.AreEqual(381,distanceConverter.Calculate(12.5));

            distanceConverter.From = distanceConverter.AvailableUnits[7];
            distanceConverter.To = distanceConverter.AvailableUnits[10];
            Assert.AreEqual("mi",distanceConverter.From.descriptor);
            Assert.AreEqual("HS",distanceConverter.To.descriptor);
            Assert.AreEqual(368615.49523,distanceConverter.Calculate(48.1), 0.00001);
        }

        [Test]
        public void SpeedTest()
        {
            Speed speedConverter = (Speed)converters[1];
            speedConverter.From = speedConverter.AvailableUnits[0];
            speedConverter.To = speedConverter.AvailableUnits[0];
            Assert.AreEqual(200,speedConverter.Calculate(200));
            Assert.AreEqual("m/s",speedConverter.From.descriptor);

            speedConverter.From = speedConverter.AvailableUnits[4];
            speedConverter.To = speedConverter.AvailableUnits[1];
            Assert.AreEqual("ft/s",speedConverter.From.descriptor);
            Assert.AreEqual("km/h",speedConverter.To.descriptor);
            Assert.AreEqual(258.498488,speedConverter.Calculate(235.6), 0.000001);

            speedConverter.From = speedConverter.AvailableUnits[7];
            speedConverter.To = speedConverter.AvailableUnits[9];
            Assert.AreEqual("kn",speedConverter.From.descriptor);
            Assert.AreEqual("Leopard",speedConverter.To.descriptor);
            Assert.AreEqual(0.517595,speedConverter.Calculate(16.2), 0.00001);
        }

        [Test]
        public void WeightTest()
        {
            Weight weightConverter = (Weight)converters[3];
            weightConverter.From = weightConverter.AvailableUnits[0];
            weightConverter.To = weightConverter.AvailableUnits[0];
            Assert.AreEqual(200,weightConverter.Calculate(200));
            Assert.AreEqual("mg",weightConverter.From.descriptor);

            weightConverter.From = weightConverter.AvailableUnits[4];
            weightConverter.To = weightConverter.AvailableUnits[1];
            Assert.AreEqual("dag",weightConverter.From.descriptor);
            Assert.AreEqual("cg",weightConverter.To.descriptor);
            Assert.AreEqual(15230,weightConverter.Calculate(15.23));

            weightConverter.From = weightConverter.AvailableUnits[7];
            weightConverter.To = weightConverter.AvailableUnits[10];
            Assert.AreEqual("Kg",weightConverter.From.descriptor);
            Assert.AreEqual("ozt",weightConverter.To.descriptor);
            Assert.AreEqual(1140.8360128,weightConverter.Calculate(35.48), 0.00001);
        }

        [Test]
        public void TemperatureTest()
        {
            Temperature temperatureConverter = (Temperature)converters[2];
            temperatureConverter.From = temperatureConverter.AvailableUnits[0];
            temperatureConverter.To = temperatureConverter.AvailableUnits[0];
            TemperatureUnit fromTemp = (TemperatureUnit)temperatureConverter.From;
            TemperatureUnit toTemp = (TemperatureUnit)temperatureConverter.To;
            Assert.AreEqual(200,temperatureConverter.Calculate(200,fromTemp.celsiusOffset,toTemp.celsiusOffset));
            Assert.AreEqual("Cº",temperatureConverter.From.descriptor);

            temperatureConverter.From = temperatureConverter.AvailableUnits[0];
            temperatureConverter.To = temperatureConverter.AvailableUnits[1];
            fromTemp = (TemperatureUnit)temperatureConverter.From;
            toTemp = (TemperatureUnit)temperatureConverter.To;
            Assert.AreEqual("Cº",temperatureConverter.From.descriptor);
            Assert.AreEqual("K",temperatureConverter.To.descriptor);
            Assert.AreEqual(273.15,temperatureConverter.Calculate(0, fromTemp.celsiusOffset, toTemp.celsiusOffset), 0.01);

            temperatureConverter.From = temperatureConverter.AvailableUnits[0];
            temperatureConverter.To = temperatureConverter.AvailableUnits[2];
            fromTemp = (TemperatureUnit)temperatureConverter.From;
            toTemp = (TemperatureUnit)temperatureConverter.To;
            Assert.AreEqual("Cº",temperatureConverter.From.descriptor);
            Assert.AreEqual("ºF",temperatureConverter.To.descriptor);
            Assert.AreEqual(50.181818,temperatureConverter.Calculate(10, fromTemp.celsiusOffset, toTemp.celsiusOffset), 0.00001);
        }
    }
}