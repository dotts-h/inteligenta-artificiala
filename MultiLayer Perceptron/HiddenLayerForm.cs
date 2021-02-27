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
    public partial class HiddenLayerForm : Form
    {
        public MHiddenLayerHeader Layer { get; set; }
        public HiddenLayerForm()
        {
            InitializeComponent();            
        }

        public void init()
        {
            globalInputComboBox.Text = Layer.InputFunction;
            activationComboBox.Text = Layer.ActivationFunction;

            thetaUpDown.Value = Layer.Theta;
            gUpDown.Value = Layer.G;
            aUpDown.Value = Layer.A;
            //Console.WriteLine(Layer.Theta);
            //Console.WriteLine(Layer.G);

            updateActivationGUI(
                Layer.IsTheta,
                Layer.IsG,
                Layer.IsA,
                Layer.OutputFunction);
            //Console.WriteLine(Layer.Theta);
            //Console.WriteLine(Layer.G);
        }
        private void globalInputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Layer.InputFunction = globalInputComboBox.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Layer.ActivationFunction = activationComboBox.Text;

            if (activationComboBox.Text.Equals("Treapta"))
            {
                updateActivationGUI(true, false, false, false);
                gUpDown.Value = 1.0m;
                aUpDown.Value = 1.0m;
            }
            if (activationComboBox.Text.Equals("Sigmoidala"))
            {
                updateActivationGUI(true, true, false, true);
                aUpDown.Value = 1.0m;
            }
            if (activationComboBox.Text.Equals("Signum"))
            {
                updateActivationGUI(true, false, false, false);
                gUpDown.Value = 1.0m;
                aUpDown.Value = 1.0m;
            }
            if (activationComboBox.Text.Equals("TanH"))
            {
                updateActivationGUI(true, true, false, true);
                aUpDown.Value = 1.0m;
            }
            if (activationComboBox.Text.Equals("Rampa"))
            {
                updateActivationGUI(true, false, true, true);
                gUpDown.Value = 1.0m;
            }
        }

        private void updateActivationGUI(bool t, bool g, bool a, bool b)
        {
            thetaUpDown.Visible = t;
            thetaLabel.Visible = t;
            Layer.IsTheta = t;

            gUpDown.Visible = g;
            gLabel.Visible = g;
            Layer.IsG = g;

            aUpDown.Visible = a;
            aLabel.Visible = a;
            Layer.IsA = a;

            binaryCheckBox.Enabled = b;
            Layer.OutputFunction = b;
            binaryCheckBox.Checked = Layer.IsBinary;
        }

        private void thetaUpDown_ValueChanged(object sender, EventArgs e)
        {
            Layer.Theta = thetaUpDown.Value;
        }

        private void gUpDown_ValueChanged(object sender, EventArgs e)
        {
            Layer.G = gUpDown.Value;
        }

        private void aUpDown_ValueChanged(object sender, EventArgs e)
        {
            Layer.A = aUpDown.Value;
        }

        private void binaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Layer.IsBinary = binaryCheckBox.Checked;
            //Console.WriteLine(binaryCheckBox.Checked);
        }
    }
}
