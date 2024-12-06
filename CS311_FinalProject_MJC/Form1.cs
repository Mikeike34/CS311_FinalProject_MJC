namespace CS311_FinalProject_MJC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void metersToFeet()
        {
            try
            {
                double meterConvert = Convert.ToDouble(txtFrom1.Text);
                double result = meterConvert * 3.28084;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(meterConvert) +" Meters " + " * 3.28084";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void feetToMeters()
        {
            try
            {
                double feetConvert = Convert.ToDouble(txtFrom1.Text);
                double result = feetConvert * 0.3048;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(feetConvert) + " Feet " + " * 0.3048";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void rdoMetersFrom_CheckedChanged(object sender, EventArgs e)
        {
            lblResult1.Text = "Feet";
            lblFrom1.Text = "Meters";

            metersToFeet();
        }


        private void rdoFeetFrom_CheckedChanged(object sender, EventArgs e)
        {
            lblResult1.Text = "Meters";
            lblFrom1.Text = "Feet";

            feetToMeters();
        }


        private void kilometersToMiles()
        {
            try
            {
                double kilometerConvert = Convert.ToDouble(txtFrom1.Text);
                double result = kilometerConvert * 0.621371;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(kilometerConvert) + " Kilometers " + " * 0.621371";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void milesToKilometers()
        {
            try
            {
                double mileConvert = Convert.ToDouble(txtFrom1.Text);
                double result = mileConvert * 1.60934;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(mileConvert) + " Miles " + " * 1.60934";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private void rdoFromKilometers_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Kilometers";
            lblResult1.Text = "Miles";

            kilometersToMiles();

        }

        private void rdoFromMiles_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Miles";
            lblResult1.Text = "Kilometers";

            milesToKilometers();
        }

        private void celsiusToFahrenheit()
        {
            try
            {
                double celsiusConvert = Convert.ToDouble(txtFrom1.Text);
                double result = (celsiusConvert * 9 / 5) + 32;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = "("+Convert.ToString(celsiusConvert) + " Degrees " + " * 9/5) + 32";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void fahrenheitToCelsius()
        {
            try
            {
                double fahrenheitConvert = Convert.ToDouble(txtFrom1.Text);
                double result = (fahrenheitConvert - 32) * 5 / 9;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = "(" + Convert.ToString(fahrenheitConvert) + " Degrees " + " - 32) * 5/9";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void rdoFromCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Celsius";
            lblResult1.Text = "Fahrenheit";

            celsiusToFahrenheit();
        }

        private void rdoFromFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Fahrenheit";
            lblResult1.Text = "Celsius";

            fahrenheitToCelsius();
        }

        private void kilogramsToPounds()
        {
            try
            {
                double kilogramConvert = Convert.ToDouble(txtFrom1.Text);
                double result = kilogramConvert * 2.205;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(kilogramConvert) + " Kilograms " + " * 2.205";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void poundsToKilograms()
        {
            try
            {
                double poundConvert = Convert.ToDouble(txtFrom1.Text);
                double result = poundConvert / 2.205;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(poundConvert) + " Pounds " + " / 2.205";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void rdoFromKilograms_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Kilograms";
            lblResult1.Text = "Pounds";

            kilogramsToPounds();
        }

        private void rdoFromPounds_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Pounds";
            lblResult1.Text = "Kilograms";

            poundsToKilograms();
        }


        private void gramsToOunces()
        {
            try
            {
                double gramConvert = Convert.ToDouble(txtFrom1.Text);
                double result = gramConvert / 28.35;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(gramConvert) + " Grams " + " / 28.35";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ouncesToGrams()
        {
            try
            {
                double ounceConvert = Convert.ToDouble(txtFrom1.Text);
                double result = ounceConvert * 28.35;

                txtResult1.Text = Convert.ToString(result);

                lblFormula.Text = Convert.ToString(ounceConvert) + " Ounces " + " * 28.35";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void rdoFromGrams_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Grams";
            lblResult1.Text = "Ounces";

            gramsToOunces();
        }

        private void rdoFromOunces_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom1.Text = "Ounces";
            lblResult1.Text = "Grams";

            ouncesToGrams();
        }

        private void txtFrom1_TextChanged(object sender, EventArgs e)
        {
            if (rdoFeetFrom.Checked)
            {
                feetToMeters();
            }
            else if (rdoMetersFrom.Checked)
            {
                metersToFeet();
            }
            else if (rdoFromKilometers.Checked)
            {
                kilometersToMiles();
            }
            else if (rdoFromMiles.Checked)
            {
                milesToKilometers();
            }
            else if (rdoFromCelsius.Checked)
            {
                celsiusToFahrenheit();
            }
            else if (rdoFromFahrenheit.Checked)
            {
                fahrenheitToCelsius();
            }
            else if (rdoFromKilograms.Checked)
            {
                kilogramsToPounds();
            }
            else if (rdoFromPounds.Checked)
            {
                poundsToKilograms();
            }
            else if (rdoFromGrams.Checked)
            {
                gramsToOunces();
            }
            else if (rdoFromOunces.Checked)
            {
                ouncesToGrams();
            }
        }

    }
}
