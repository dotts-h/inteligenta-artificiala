using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neuron_1
{
    public partial class Form1 : Form
    {
        static decimal lastValue = 1;

        static Stack<Tuple<NumericUpDown, NumericUpDown>> inputs = new Stack<Tuple<NumericUpDown, NumericUpDown>>();

        public Form1()
        {
            InitializeComponent();
            inputs.Push(generateInputAndWeight());

            flowLayoutPanel1.Controls.Add(inputs.Peek().Item1);
            flowLayoutPanel1.Controls.Add(inputs.Peek().Item2);

            sumRadioButton.Checked = true;

            treaptaRadioButton.Checked = true;
            gUpDown.Value = 1;

            aUpDown.Value = 1;

            computeAndUpdateUI_ValueChanged(new object(), new EventArgs());
        }

        private void generate_numericUpAndDown_ValueChanged(object sender, EventArgs e)
        {
            fillListBasedOnValueChange(generate_numericUpAndDown.Value);

            resetPanelBasedOnValueChange();

            lastValue = generate_numericUpAndDown.Value;
        }

        private Tuple<NumericUpDown, NumericUpDown> generateInputAndWeight()
        {
            return new Tuple<NumericUpDown, NumericUpDown>(generateNumericUpAndDown(),
                generateNumericUpAndDown());
        }

        // generate numerical upanddown
        private NumericUpDown generateNumericUpAndDown()
        {
            NumericUpDown num = new NumericUpDown();
            num.Value = 0;
            num.Minimum = -100;
            num.Maximum = 100;
            num.Increment = 0.01m;
            num.DecimalPlaces = 2;
            num.Width = 70;
            num.TextAlign = HorizontalAlignment.Center;
            num.ValueChanged += computeAndUpdateUI_ValueChanged;

            return num;
        }

        // fill lists based on updown value
        private void fillListBasedOnValueChange(decimal x)
        {
            decimal t = x - lastValue;
            Console.WriteLine(t);

            if (t > 0)
            {
                for(int i = 0; i < t; ++i)
                {
                    inputs.Push(generateInputAndWeight());
                }
            } else if(t < 0)
            {
                for(decimal i = t; i < 0; ++i)
                {
                    Tuple<NumericUpDown, NumericUpDown> s = inputs.Pop();
                    Console.WriteLine(i);
                }
            }
        }

        // reset panel based on changed value
        private void resetPanelBasedOnValueChange()
        {
            flowLayoutPanel1.Controls.Clear();
            Console.WriteLine(inputs.Count);
            foreach(Tuple<NumericUpDown,NumericUpDown> x in inputs.Reverse())
            {
                flowLayoutPanel1.Controls.Add(x.Item1);
                flowLayoutPanel1.Controls.Add(x.Item2);
                Console.WriteLine(x);
            }
        }

        /// Global Input
        private decimal sumInputs()
        {
            decimal t = 0;

            foreach(Tuple<NumericUpDown,NumericUpDown> x in inputs.Reverse())
            {
                t += (x.Item1.Value * x.Item2.Value);
            }

            return t;
        }

        private decimal productInputs()
        {
            decimal t = 1;

            foreach (Tuple<NumericUpDown, NumericUpDown> x in inputs.Reverse())
            {
                t *= (x.Item1.Value * x.Item2.Value);
            }

            return t;
        }

        private decimal minInputs()
        {
            decimal t = inputs.Peek().Item1.Value * inputs.Peek().Item2.Value;

            foreach (Tuple<NumericUpDown, NumericUpDown> x in inputs.Reverse())
            {
                decimal z = x.Item1.Value * x.Item2.Value;
                if (z < t)
                {
                    t = z;
                }
            }

            return t;
        }

        private decimal maxInputs()
        {
            decimal t = inputs.Peek().Item1.Value * inputs.Peek().Item2.Value;

            foreach (Tuple<NumericUpDown, NumericUpDown> x in inputs.Reverse())
            {
                decimal z = x.Item1.Value * x.Item2.Value;
                if (z > t)
                {
                    t = z;
                }
            }

            return t;
        }

        // compute Global Input based on selected function
        private void computeGlobalInput()
        {
            decimal t = 0;

            if (sumRadioButton.Checked)
            {
                t = sumInputs();
            }
            if (productRadioButton.Checked)
            {
                t = productInputs();
            }
            if (minRadioButton.Checked)
            {
                t = minInputs();
            }
            if (maxRadioButton.Checked)
            {
                t = maxInputs();
            }

            globalInputTextBox.Text = t.ToString();
        }

        private void inputsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeGlobalInput();
        }

        /// Activation
        private decimal treaptaGlobalInput()
        {
            decimal gi = Decimal.Parse(globalInputTextBox.Text);
            decimal t = thetaUpDown.Value;

            if (gi < t)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private decimal sigmoidalaGlobalInput()
        {
            decimal gi = Decimal.Parse(globalInputTextBox.Text);
            decimal g = gUpDown.Value;
            decimal t = thetaUpDown.Value;
            decimal _exp = -(g * (gi - t));
            decimal _den = 1 + (decimal)Math.Pow(Math.E, (double) _exp);

            return (1 / _den);
        }

        private decimal signumGlobalInput()
        {
            decimal gi = Decimal.Parse(globalInputTextBox.Text);
            decimal t = thetaUpDown.Value;

            if(gi < t)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private decimal tanHGlobalInput()
        {
            decimal gi = Decimal.Parse(globalInputTextBox.Text);
            decimal g = gUpDown.Value;
            decimal t = thetaUpDown.Value;
            decimal _expPoz = g * (gi - t);
            decimal _expNeg = -(g * (gi - t));
            decimal _e_to_poz = (decimal)Math.Pow(Math.E, (double)_expPoz);
            decimal _e_to_neg = (decimal)Math.Pow(Math.E, (double)_expNeg);
            decimal _num = _e_to_poz - _e_to_neg;
            decimal _den = _e_to_poz + _e_to_neg;

            return (_num / _den);
        }

        private decimal rampaGlobalInput()
        {
            decimal t = thetaUpDown.Value;
            decimal a = aUpDown.Value;
            decimal gi = Decimal.Parse(globalInputTextBox.Text) - t;
            
            if (gi < -a)
            {
                return -1;
            }
            else if (gi > a)
            {
                return 1;
            }
            else
            {
                return (gi / a);
            }
        }

        // compute Activation based on selected function
        private void computeActivation()
        {
            decimal t = 0;
            decimal o = 0;

            if (treaptaRadioButton.Checked)
            {
                thetaUpDown.Visible = true;
                thetaLabel.Visible = true;
                gUpDown.Visible = false;
                gLabel.Visible = false;
                aUpDown.Visible = false;
                aLabel.Visible = false;

                t = treaptaGlobalInput();
            }
            if (sigmoidalaRadioButton.Checked)
            {
                thetaUpDown.Visible = true;
                thetaLabel.Visible = true;
                gUpDown.Visible = true;
                gLabel.Visible = true;
                aUpDown.Visible = false;
                aLabel.Visible = false;

                t = sigmoidalaGlobalInput();
            }
            if (signumRadioButton.Checked)
            {
                thetaUpDown.Visible = true;
                thetaLabel.Visible = true;
                gUpDown.Visible = false;
                gLabel.Visible = false;
                aUpDown.Visible = false;
                aLabel.Visible = false;

                t = signumGlobalInput();
            }
            if (tanHRadioButton.Checked)
            {
                thetaUpDown.Visible = true;
                thetaLabel.Visible = true;
                gUpDown.Visible = true;
                gLabel.Visible = true;
                aUpDown.Visible = false;
                aLabel.Visible = false;

                t = tanHGlobalInput();
            }
            if (rampaRadioButton.Checked)
            {
                thetaUpDown.Visible = true;
                thetaLabel.Visible = true;
                gUpDown.Visible = false;
                gLabel.Visible = false;
                aUpDown.Visible = true;
                aLabel.Visible = true;

                t = rampaGlobalInput();
            }

            activationTextBox.Text = t.ToString();
        }

        private void activationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeActivation();
        }

        // compute Output based on function selected
        private void computeOutput()
        {
            decimal t = 0;

            if (treaptaRadioButton.Checked)
            {
                binarCheckBox.Visible = false;

                t = Decimal.Parse(activationTextBox.Text);
            }
            if (sigmoidalaRadioButton.Checked)
            {
                binarCheckBox.Visible = true;

                if (binarCheckBox.Checked)
                {
                    decimal o = Decimal.Parse(activationTextBox.Text);

                    if (o < 0.5m)
                    {
                        t = 0;
                    }
                    else
                    {
                        t = 1;
                    }
                }
                else
                {
                    t = Decimal.Parse(activationTextBox.Text);
                }
            }
            if (signumRadioButton.Checked)
            {
                binarCheckBox.Visible = false;

                t = Decimal.Parse(activationTextBox.Text);
            }
            if (tanHRadioButton.Checked)
            {
                binarCheckBox.Visible = true;

                if (binarCheckBox.Checked)
                {
                    decimal o = Decimal.Parse(activationTextBox.Text);

                    if (o < 0)
                    {
                        t = -1;
                    }
                    else
                    {
                        t = 1;
                    }
                }
                else
                {
                    t = Decimal.Parse(activationTextBox.Text);
                }
            }
            if (rampaRadioButton.Checked)
            {
                binarCheckBox.Visible = true;

                if (binarCheckBox.Checked)
                {
                    decimal o = Decimal.Parse(activationTextBox.Text);

                    if (o < 0)
                    {
                        t = -1;
                    }
                    else
                    {
                        t = 1;
                    }
                }
                else
                {
                    t = Decimal.Parse(activationTextBox.Text);
                }
            }

            outputTextBox.Text = t.ToString();
        }


        // Do all Computations and update UI
        private void computeAndUpdateUI_ValueChanged(object sender, EventArgs e)
        {
            computeGlobalInput();
            computeActivation();
            computeOutput();
        }
    }
}
