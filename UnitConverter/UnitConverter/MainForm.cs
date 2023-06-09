using Converter;
using Converter.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class MainForm : Form
    {
        private IConverter mainConverter;



        public MainForm()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                switch(selectedRadioButton.Name) 
                {
                    case "rdBtnWeight":
                        mainConverter = new Weight();
                        break;
                    case "rdBtnTemperature":
                        break;
                    case "rdBtnSpeed":
                        break;
                    case "rdBtnDistance":
                        mainConverter = new Converters();
                        break;


                }

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

            mainConverter.SetUnitsListRelative(this.lstBxConvertFrom.SelectedIndex, this.lstBxConvertTo.SelectedIndex);

            if (double.TryParse(this.nmTxBxToConvert.Text, out valueToConvert)) 
            {
                result = mainConverter.Calculate(valueToConvert);
                this.lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Ves, por aqui ibamos a salir", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
