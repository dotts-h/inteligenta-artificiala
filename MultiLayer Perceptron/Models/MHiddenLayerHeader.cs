using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLayer_Perceptron.Models
{
    public class MHiddenLayerHeader
    {
        Tuple<Button, NumericUpDown> hiddenLayerHeader;
        public String InputFunction { get; set; }
        public String ActivationFunction { get; set; }
        public bool OutputFunction { get; set; }
        public bool IsBinary { get; set; }
        public bool IsTheta { get; set; }
        public decimal Theta { get; set; }
        public bool IsG { get; set; }
        public decimal G { get; set; }
        public bool IsA { get; set; }
        public decimal A { get; set; }
        public Tuple<Button, NumericUpDown> Header
        {
            get => hiddenLayerHeader;
        }

        public Button Button
        {
            get => hiddenLayerHeader.Item1;
        }

        public NumericUpDown Numeric
        {
            get => hiddenLayerHeader.Item2;
        }

        public MHiddenLayerHeader()
        {
            hiddenLayerHeader = new Tuple<Button, NumericUpDown>(
                new Button(),
                new NumericUpDown());

            InputFunction = "Sum";
            ActivationFunction = "Treapta";

            IsTheta = true;
            Theta = 0.0m;

            IsG = false;
            G = 1.0m;

            IsA = false;
            A = 1.0m;

            OutputFunction = false;
            IsBinary = false;



            InitElements();
        }

        private void InitElements()
        {
            // load data
            var hLayer = this;

            // button
            var b = hiddenLayerHeader.Item1;
            b.Text = "Set";
            b.Width = 50;
            b.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            b.Dock = DockStyle.Left;
            b.Click += (object o, EventArgs e) =>
            {
                var s = new HiddenLayerForm();
                s.Layer = hLayer;
                s.init();
                s.Show();
                Point location = Form1.MousePosition;
                s.Top = location.Y - (s.Height / 2);
                s.Left = location.X - (s.Width / 2);
            };
            

            // numeric
            var num = hiddenLayerHeader.Item2;
            num.Value = 1;
            num.Minimum = 1;
            num.Maximum = 100;
            num.Increment = 1;
            num.Width = 50;
            num.TextAlign = HorizontalAlignment.Center;
            num.Anchor = AnchorStyles.None;
        }
    }
}
