using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLayer_Perceptron.Models
{
    public partial class MNeuron
    {
        public int maxInputs { get; set; }
        public List<decimal> Inputs { get; set; }
        public List<decimal> Weights { get; set; }
        public List<(decimal Input, decimal Weight)> InputWeights { get; set; }
        public decimal Output { get; set; }
        public decimal GlobalInput { get; set; }
        public TextBox OutputTextBox { get; set; }
        public Button Button { get; }
        //public bool IsTheta { get; set; }
        //public decimal Theta { get; set; }
        //public bool IsG { get; set; }
        //public decimal G { get; set; }
        //public bool IsA { get; set; }
        //public decimal A { get; set; }

        //public List<Tuple<decimal, decimal>> InputWeights
        //{
        //    get => neuronInputsWeights;
        //    set;
        //}

        public MNeuron()
        {
            InputWeights = new List<(decimal Input, decimal Weight)>();
            //neuronInputsWeights.Push(new Tuple<TextBox, NumericUpDown>(
            //    new TextBox(),
            //    new NumericUpDown()));
            Inputs = new List<decimal>();
            Weights = new List<decimal>();
            var input = 0.0m;
            var weight = 0.0m;
            Inputs.Add(input);
            Weights.Add(weight);
            maxInputs = 0;
            Button = new Button();
            OutputTextBox = generateTextBox();
            // adauga initiere form

            InitElements();
        }

        private void InitElements()
        {
            // load data
            var nStack = this;

            // button
            var b = Button;
            b.Text = "Set";
            b.Width = 50;
            //b.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            b.Anchor = AnchorStyles.None;
            b.Dock = DockStyle.Left;
            b.Click += (object o, EventArgs e) =>
            {
                var s = new NeuronForm();
                s.Neuron = nStack;
                s.init();
                s.Show();
                Point location = Form1.MousePosition;
                s.Top = location.Y - (s.Height / 2);
                s.Left = location.X - (s.Width / 2);
            };


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
            num.Value = 1;
            num.Minimum = 1;
            num.Maximum = 100;
            num.Increment = 1;
            num.Width = 50;
            num.TextAlign = HorizontalAlignment.Center;
            num.Anchor = AnchorStyles.None;

            return num;
        }

        //private NumericUpDown generateNumeric()
        //{
        //    var num = new NumericUpDown();
        //    num.Value = 1;
        //    num.Minimum = 1;
        //    num.Maximum = 100;
        //    num.Increment = 1;
        //    num.Width = 50;
        //    num.TextAlign = HorizontalAlignment.Center;
        //    num.Anchor = AnchorStyles.None;

        //    return num;
        //}
    }
}
