using Converter;
using Converter.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class MainForm : Form
    {
        private IConverter mainConverter;

        private List<IConverter> convertersCache = new List<IConverter>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            IConverter toUse = null;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                switch(selectedRadioButton.Name) 
                {
                    case "rdBtnWeight":
                        toUse = convertersCache.FirstOrDefault(c => c.GetType() == typeof(Weight));
                        if (toUse==null) 
                        {
                            toUse = new Weight();
                            convertersCache.Add(toUse);
                        }
                        break;
                    case "rdBtnTemperature":
                        toUse = convertersCache.FirstOrDefault(c => c.GetType() == typeof(Temperature));
                        if (toUse==null) 
                        {
                            toUse = new Temperature();
                            convertersCache.Add(toUse);
                        }
                        break;
                    case "rdBtnSpeed":
                        toUse = convertersCache.FirstOrDefault(c => c.GetType() == typeof(Speed));
                        if (toUse==null) 
                        {
                            toUse = new Speed();
                            convertersCache.Add(toUse);
                        }
                        break;
                    case "rdBtnDistance":
                        toUse = convertersCache.FirstOrDefault(c => c.GetType() == typeof(Distance));
                        if (toUse==null) 
                        {
                            toUse = new Distance();
                            convertersCache.Add(toUse);
                        }
                        break;
                }
                mainConverter = toUse;
            }
            PopulateUnits();
            ClearForm();
        }

        private void PopulateUnits() 
        {
            this.lstBxConvertFrom.Items.Clear();
            this.lstBxConvertTo.Items.Clear();

            foreach(IUnit currentUnit in mainConverter.AvailableUnits) 
            {
                this.lstBxConvertFrom.Items.Add(currentUnit.descriptor);
                this.lstBxConvertTo.Items.Add(currentUnit.descriptor);
            }
        }

        private void ClearForm() 
        {
            this.nmTxBxToConvert.Clear();
            this.lstBxConvertFrom.SelectedIndex = 0;
            this.lstBxConvertTo.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double valueToConvert = 0, result = 0;
            if (String.IsNullOrEmpty(this.nmTxBxToConvert.Text)) return;
            mainConverter.SetUnitsListRelative(this.lstBxConvertFrom.SelectedIndex, this.lstBxConvertTo.SelectedIndex);

            if (double.TryParse(this.nmTxBxToConvert.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out valueToConvert)) 
            {
                if (mainConverter.masterUnit == Converter.Enums.Units.Celsius)
                {
                    TemperatureUnit fromTemperature = (TemperatureUnit)mainConverter.From;
                    TemperatureUnit toTemperature = (TemperatureUnit)mainConverter.To;
                    result = mainConverter.Calculate(valueToConvert, fromTemperature.celsiusOffset, toTemperature.celsiusOffset);
                }
                else
                {
                    result = mainConverter.Calculate(valueToConvert);
                }
                this.lblResult.Text =String.Format("{0}{1} are {2}{3}",valueToConvert, mainConverter.From.descriptor, result.ToString(), mainConverter.To.descriptor);
            }
            else
            {
                MessageBox.Show("Unable to parse value", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SetTexts();
        }

        private void SetTexts() 
        {
            lblResult.Text = "Enter a value, select the units to convert, and press the calculate button.";
            lblTxtFrom.Text = "From:";
            lblTxtTo.Text = "To:";
            lblTxtValue.Text = "Value to convert:";
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
