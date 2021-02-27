using MultiLayer_Perceptron.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLayer_Perceptron
{
    public partial class NeuronForm : Form
    {
        public MNeuron Neuron { get; set; }

        public NeuronForm()
        {
            InitializeComponent();

            var globalInputLabel = new Label();
            globalInputLabel.Text = "Global Input";
            globalInputLabel.Anchor = AnchorStyles.None;

            var outputLabel = new Label();
            outputLabel.Text = "Output";
            outputLabel.Anchor = AnchorStyles.None;

            neuronTableLayout.Controls.Add(globalInputLabel, 0, 0);
            neuronTableLayout.Controls.Add(outputLabel, 0, 1);

            var inputsLabel = new Label();
            inputsLabel.Text = "Inputs";
            inputsLabel.BorderStyle = BorderStyle.Fixed3D;
            inputsLabel.TextAlign = ContentAlignment.MiddleCenter;
            inputsLabel.Anchor = AnchorStyles.None;

            var weightsLabel = new Label();
            weightsLabel.Text = "Weights";
            weightsLabel.BorderStyle = BorderStyle.Fixed3D;
            weightsLabel.TextAlign = ContentAlignment.MiddleCenter;
            weightsLabel.Anchor = AnchorStyles.None;

            neuronTableLayout.Controls.Add(inputsLabel, 0, 2);
            neuronTableLayout.Controls.Add(weightsLabel, 1, 2);
        }
        private TextBox generateTextBox()
        {
            var tb = new TextBox();
            tb.ReadOnly = true;
            tb.Height = 40;
            tb.Width = 150;
            tb.TextAlign = HorizontalAlignment.Center;
            tb.Anchor = AnchorStyles.None;

            return tb;
        }

        private NumericUpDown generateNumeric()
        {
            // numeric
            var num = new NumericUpDown();
            //num.Value = 1;
            num.Minimum = -100;
            num.Maximum = 100;
            num.Increment = 0.01m;
            num.DecimalPlaces = 2;
            num.Width = 70;
            num.TextAlign = HorizontalAlignment.Center;
            num.Anchor = AnchorStyles.None;

            return num;
        }

        public void init()
        {
            var gi = generateTextBox();
            gi.Text = Neuron.GlobalInput.ToString();
            var t = generateTextBox();
            t.Text = Neuron.Output.ToString();

            neuronTableLayout.Controls.Add(gi, 1, 0);
            neuronTableLayout.Controls.Add(t, 1, 1);

            int i = 3;

            for (int j = 0; j < Neuron.Inputs.Count; ++j)
            {
                var inputs = Neuron.Inputs;
                var weights = Neuron.Weights;

                var input = generateTextBox();
                input.Text = inputs[j].ToString();
                var weight = generateNumeric();
                weight.Value = weights[j];
                //weight.ValueChanged += (object o, EventArgs e) =>
                //{
                //    weights[j] = weight.Value;
                //};
                weight.ValueChanged += updateData;

                neuronTableLayout.Controls.Add(input, 0, i);
                neuronTableLayout.Controls.Add(weight, 1, i);

                ++i;
            }
        }

        private void updateData(object o, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)o;
            var index = num.TabIndex / 2 - 3;
            //var el = Neuron.InputWeights[index];
            //Console.WriteLine("inainte el: " + el.Weight + "\t" + "we: " + num.Value);
            //el.Weight = num.Value;
            //Console.WriteLine("dupa el: " + el.Weight + "\t" + "we: " + num.Value);
            Neuron.Weights[index] = num.Value;
        }


    }
}
