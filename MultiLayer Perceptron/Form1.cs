using MultiLayer_Perceptron.Helpers;
using MultiLayer_Perceptron.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MultiLayer_Perceptron
{
    public partial class Form1 : Form
    {
        static int lastColumn = 2;
        List<NumericUpDown> list = new List<NumericUpDown>();

        // Inputs Generation
        static decimal inputsLastValue = 1;
        GroupBox inputsGenerationBox;
        Stack<NumericUpDown> inputsGenerationStack = new Stack<NumericUpDown>();

        // Outputs Generation
        static decimal outputsLastValue = 1;
        GroupBox outputsGenerationBox;
        Stack<TextBox> outputsGenerationStack = new Stack<TextBox>();
        Tuple<MHiddenLayerHeader, MNeuronStack> outputLayer = new Tuple<MHiddenLayerHeader, MNeuronStack>(
            new MHiddenLayerHeader(),
            new MNeuronStack());

        // Hiden Layers Generation
        static decimal hiddenLayersLastValue = 1;
        static decimal hiddenLayerLastValue1 = 1;
        static decimal hiddenLayerLastValue2 = 1;
        static decimal hiddenLayerLastValue3 = 1;
        GroupBox hiddenLayerGenerationBox;
        //Stack<Tuple<Tuple<Button, HiddenLayerForm>, Stack<Tuple<Button, NeuronForm>>>> hiddenLayersNeuronsStack = new Stack<Tuple<Tuple<Button, HiddenLayerForm>, Stack<Tuple<Button, NeuronForm>>>>();
        MHiddenLayer hiddenLayers = new MHiddenLayer();


        public Form1()
        {
            InitializeComponent();

            // Inputs Generation
            inputsGenerationBox = generateHeader("Inputs");
            inputsGenerationBox.Controls.OfType<NumericUpDown>().First<NumericUpDown>().ValueChanged += inputsChangedValue;

            var x = generateNumericUpAndDown();

            // groupbox
            var gb = new GroupBox();
            gb.Text = "Input " + 1;
            gb.Anchor = AnchorStyles.None;
            gb.Controls.Add(x);

            // set numeric to center
            x.Left = (gb.Width - x.Width) / 2;
            x.Top = (gb.Height - x.Height) / 2;

            // add
            inputsGenerationStack.Push(x);

            // -------------

            // Outputs Generation
            outputsGenerationBox = generateHeader("Outputs");
            outputsGenerationBox.Controls.OfType<NumericUpDown>().First<NumericUpDown>().ValueChanged += outputsChangedValue;

            var xO = generateTextBox();

            // groupbox
            var gbO = new GroupBox();
            gbO.Text = "Output " + 1;
            gbO.Anchor = AnchorStyles.None;
            gbO.Controls.Add(x);

            // set numeric to center
            xO.Left = (gbO.Width - xO.Width) / 2;
            xO.Top = (gbO.Height - xO.Height) / 2;

            // add
            outputsGenerationStack.Push(xO);

            // New Outputs Generation
            outputLayer.Item1.Numeric.ValueChanged += outputsChangedValue;

            // -------------

            // Hidden Layers Generation
            hiddenLayers.LayerList[0].Item1.Numeric.ValueChanged += layerChangedValue1;
            //hiddenLayerGenerationBox = generateHiddenLayerHeader("Hidden Layer Neurons 1");
            //hiddenLayerGenerationBox.Controls.OfType<NumericUpDown>().First<NumericUpDown>().ValueChanged += outputsChangedValue;

            //var xH = new Tuple<Button, HiddenLayerForm>(new Button(), new HiddenLayerForm());
            //xH.Item1.Text = "Layer 1 Settings";
            //xH.Item1.Click += (object o, EventArgs e) => xH.Item2.Show();


            //// groupbox
            //var gbH = new GroupBox();
            //gbH.Text = "Hidden Layer " + 1;
            //gbH.Anchor = AnchorStyles.None;
            //gbH.Controls.Add(x);

            //// set numeric to center
            //xO.Left = (gbH.Width - xO.Width) / 2;
            //xO.Top = (gbH.Height - xO.Height) / 2;

            //// test......
            //xH.Item1.Left = (gbH.Width - xO.Width) / 2;
            //xH.Item1.Top = (gbH.Height - xO.Height) / 2;
            //hiddenLayerGenerationBox.Controls.Add(xH.Item1);


            // -------------


            // FILL HEADER
            //tableLayoutPanel1.Controls.Add(gb, 0, 1);
            //tableLayoutPanel1.Controls.Add(gbO, lastColumn, 1);

            //tableLayoutPanel1.Controls.Add(inputsGenerationBox, 0, 0);
            //tableLayoutPanel1.Controls.Add(generateButton("output"), 1, 0);
            //tableLayoutPanel1.Controls.Add(outputsGenerationBox, lastColumn, 0);
            //Compute(new object(), new EventArgs());
            regenerateTableOnValueChanged(new object(), new EventArgs());
        }

        // Generate Header
        private GroupBox generateHeader(String text)
        {
            // groupbox
            var gb = new GroupBox();
            gb.Text = text;
            gb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            gb.Dock = DockStyle.Fill;
            
            // numeric
            var num = new NumericUpDown();
            num.Value = 1;
            num.Minimum = 1;
            num.Maximum = 100;
            num.Increment = 1;
            num.Width = 50;
            num.TextAlign = HorizontalAlignment.Center;
            num.Anchor = AnchorStyles.None;

            gb.Controls.Add(num);

            // set numeric to center
            num.Left = (gb.Width - num.Width) / 2;
            num.Top = (gb.Height - num.Height) / 2;

            return gb;
        }

        private GroupBox generateHiddenLayerHeader(String text, MHiddenLayerHeader hiddenLayerHeader, String tag)
        {
            // groupbox
            var gb = new GroupBox();
            gb.Text = text;
            gb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            gb.Dock = DockStyle.Fill;

            var num = hiddenLayerHeader.Numeric;
            num.Left = (gb.Width - num.Width) / 2;
            num.Top = (gb.Height - num.Height) / 2;
            num.Tag = tag;

            gb.Controls.Add(num);
            gb.Controls.Add(hiddenLayerHeader.Button);

            return gb;
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
            num.Width = 100;
            num.TextAlign = HorizontalAlignment.Center;
            num.Anchor = AnchorStyles.None;
            //num.ValueChanged += Compute;
            //num.ValueChanged += computeAndUpdateUI_ValueChanged;

            return num;
        }

        // generate Output TextBox
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


        // fill lists based on updown value
        private void fillListBasedOnValueChange(Stack<NumericUpDown> list, decimal lastValue, decimal x)
        {
            decimal t = x - lastValue;
            Console.WriteLine(t);

            if (t > 0)
            {
                for (int i = 0; i < t; ++i)
                {
                    list.Push(generateNumericUpAndDown());
                    addInputOutput(hiddenLayers.LayerList[0].Item2, checked((uint) t));
                }
            }
            else if (t < 0)
            {
                for (decimal i = t; i < 0; ++i)
                {
                    NumericUpDown s = list.Pop();
                    Console.WriteLine(i);
                    removeInputOutput(hiddenLayers.LayerList[0].Item2, (uint) (0-t));
                }
            }
        }

        // REGENERATE TABLE
        private void regenerateTableOnValueChanged(object sender, EventArgs e)
        {
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.Controls.Clear();

            // Regen Headers
            tableLayoutPanel1.Controls.Add(inputsGenerationBox, 0, 0);
            tableLayoutPanel1.Controls.Add(generateHiddenLayerHeader("Layer 1", hiddenLayers.LayerList[0].Item1, "1"), 1, 0);
            //tableLayoutPanel1.Controls.Add(outputsGenerationBox, lastColumn, 0);
            tableLayoutPanel1.Controls.Add(generateHiddenLayerHeader("Outputs", outputLayer.Item1, "0"), lastColumn, 0);

            //addInputOutput(hiddenLayers.LayerList[0].Item2, 1);
            //addInputOutput(outputLayer.Item2, 1);

            Compute(new object(), new EventArgs());


            //hiddenLayers.LayerList[0].Item1.Numeric.ValueChanged += layerChangedValue1;
            // Regen Inputs
            //inputsChangedValue(new Object(), new EventArgs());
            regenerateInputs();

            // Regen Outputs
            regenerateOutputs();

            // Regen Hidden Layers
            regenerateHiddenLayers();

            // Regen Neurons
            regenerateNeurons();

            panel1.ResumeLayout();
            tableLayoutPanel1.ResumeLayout();
        }

        // inputsChangedValue
        private void inputsChangedValue(object sender, EventArgs e)
        {
            var ctrl = inputsGenerationBox.Controls.OfType<NumericUpDown>();
            var val = ctrl.First<NumericUpDown>().Value;

            fillListBasedOnValueChange(inputsGenerationStack, inputsLastValue, val);

            inputsLastValue = val;

            regenerateTableOnValueChanged(new object(), new EventArgs());
        }

        private void regenerateInputs()
        {
            var rows = 1;

            foreach (NumericUpDown x in inputsGenerationStack.Reverse())
            {
                // groupbox
                var gb = new GroupBox();
                gb.Text = "Input " + rows;
                gb.Anchor = AnchorStyles.None;
                gb.Controls.Add(x);

                // set numeric to center
                x.Left = (gb.Width - x.Width) / 2;
                x.Top = (gb.Height - x.Height) / 2;

                // add
                tableLayoutPanel1.Controls.Add(gb, 0, rows);
                rows++;
            }
        }

        // outputsChangedValue
        private void outputsChangedValue(object sender, EventArgs e)
        {
            var ctrl = outputsGenerationBox.Controls.OfType<NumericUpDown>();
            var val = outputLayer.Item1.Numeric.Value;

            fillOutputStackBasedOnValueChange(val);

            outputsLastValue = val;

            regenerateTableOnValueChanged(new object(), new EventArgs());
        }

        private void regenerateOutputs()
        {
            var rows = 1;

            foreach (MNeuron x in outputLayer.Item2.Stack.Reverse())
            {
                // groupbox
                var gb = new GroupBox();
                gb.Text = "Output " + rows;
                gb.Anchor = AnchorStyles.None;
                gb.Controls.Add(x.OutputTextBox);
                gb.Controls.Add(x.Button);

                // set numeric to center
                x.OutputTextBox.Left = (gb.Width - x.OutputTextBox.Width) / 2 + (x.Button.Width / 2);
                x.OutputTextBox.Top = (gb.Height - x.OutputTextBox.Height) / 2;

                // add
                tableLayoutPanel1.Controls.Add(gb, lastColumn + 1, rows);
                rows++;
            }
        }

        private void fillOutputStackBasedOnValueChange(decimal x)
        {
            decimal t = x - outputsLastValue;
            Console.WriteLine(t);

            if (t > 0)
            {
                for (int i = 0; i < t; ++i)
                {
                    //outputsGenerationStack.Push(generateTextBox());
                    outputLayer.Item2.Stack.Push(new MNeuron());
                }
            }
            else if (t < 0)
            {
                for (decimal i = t; i < 0; ++i)
                {
                    //var s = outputsGenerationStack.Pop();
                    outputLayer.Item2.Stack.Pop();
                    Console.WriteLine(i);
                }
            }
        }

        // outputsChangedValue


        //private void mouseEnter(object sender, EventArgs e)
        //{
        //    inputsGenerationPanel.Controls.Remove(inputsGenerationButton);
        //    inputsGenerationPanel.Controls.Add(inputsGenerationNumeric);
        //}
        //private void mouseLeave(object sender, EventArgs e)
        //{
        //    inputsGenerationPanel.Controls.Remove(inputsGenerationNumeric);
        //    inputsGenerationPanel.Controls.Add(inputsGenerationButton);
        //}

        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    //var row = (int)numericUpDown1.Value;
        //    tableLayoutPanel1.Controls.Add(generateNumeric(), 0, row);
        //    tableLayoutPanel1.Controls.Add(generateNumeric(), lastColumn, row);
        //    tableLayoutPanel1.Controls.Add(generateNumeric(), 1, row);
        //    //static int stats = 
        //    //tableLayoutPanel1.Controls[1].Controls.remo
        //    //tableLayoutPanel1.Refresh();
        //}

        //private Button generateButton(String text)
        //{
        //    var s = new Button();
        //    s.Text = text;
        //    s.Anchor = AnchorStyles.None;

        //    return s;
        //}

        //private NumericUpDown generateNumeric()
        //{
        //    var s = new NumericUpDown();
        //    s.Anchor = AnchorStyles.None;

        //    return s;
        //}

        //private FlowLayoutPanel generatePanel()
        //{
        //    var s = new FlowLayoutPanel();
        //    s.Controls.Add(generateNumeric());
        //    s.Controls.Add(generateButton("test"));
        //    return s;
        //}

        // hiddenLayersChangedValue
        //private void addEventsToLayersUpDown()
        //{
        //    var end = hiddenLayers.LayerList.Count;
        //    for (int i = 0; i < end; ++i)
        //    {
        //        switch (i)
        //        {
        //            case 0:
        //                hiddenLayers.LayerList[i].Item1.Numeric.ValueChanged += layerChangedValue1;
        //                break;
        //            case 1:
        //                hiddenLayers.LayerList[i].Item1.Numeric.ValueChanged += layerChangedValue2;
        //                break;
        //            case 2:
        //                hiddenLayers.LayerList[i].Item1.Numeric.ValueChanged += layerChangedValue3;
        //                break;
        //        }
        //    }
        //}
        private void layerChangedValue1(object o, EventArgs e)
        {
            var val = hiddenLayers.LayerList[0].Item1.Numeric.Value;
            fillNeuronsBasedOnValueChanged(val, hiddenLayerLastValue1, 0);

            regenerateTableOnValueChanged(new object(), new EventArgs());

            hiddenLayerLastValue1 = val;
        }
        private void layerChangedValue2(object o, EventArgs e)
        {
            var val = hiddenLayers.LayerList[1].Item1.Numeric.Value;
            fillNeuronsBasedOnValueChanged(val, hiddenLayerLastValue2, 1);

            regenerateTableOnValueChanged(new object(), new EventArgs());

            hiddenLayerLastValue2 = val;
        }
        private void layerChangedValue3(object o, EventArgs e)
        {
            var val = hiddenLayers.LayerList[2].Item1.Numeric.Value;
            fillNeuronsBasedOnValueChanged(val, hiddenLayerLastValue3, 2);

            regenerateTableOnValueChanged(new object(), new EventArgs());

            hiddenLayerLastValue3 = val;
        }
        private void fillNeuronsBasedOnValueChanged(decimal x, decimal layerLastValue, int index)
        {
            decimal t = x - layerLastValue;
            Console.WriteLine(t);

            if (t > 0)
            {
                for (int i = 0; i < t; ++i)
                {
                    hiddenLayers.LayerList[index].Item2.Stack.Push(new MNeuron());
                }
            }
            else if (t < 0)
            {
                for (decimal i = t; i < 0; ++i)
                {
                    var s = hiddenLayers.LayerList[index].Item2.Stack.Pop();
                    Console.WriteLine(s);
                }
            }
        }


        //private GroupBox generateNeuron(Button bt, String text)
        //{
        //    // groupbox
        //    var gb = new GroupBox();
        //    gb.Text = text;
        //    gb.Anchor = AnchorStyles.None;

        //    //bt.Text = text;

        //    gb.Controls.Add(bt);

        //    // set numeric to center
        //    //num.Left = (gb.Width - num.Width) / 2;
        //    //num.Top = (gb.Height - num.Height) / 2;

        //    return gb;
        //}

        private void regenerateNeurons()
        {
            var columns = hiddenLayers.LayerList.Count;
            for (int i = 0; i < columns; ++i)
            {
                var rows = 1;

                foreach (MNeuron x in hiddenLayers.LayerList[i].Item2.Stack.Reverse())
                {
                    // groupbox
                    var gb = new GroupBox();
                    gb.Text = "Neuron " + rows;
                    gb.Anchor = AnchorStyles.None;
                    gb.Controls.Add(x.OutputTextBox);
                    gb.Controls.Add(x.Button);

                    // set numeric to center
                    x.OutputTextBox.Left = (gb.Width - x.OutputTextBox.Width) / 2 + (x.Button.Width / 2);
                    x.OutputTextBox.Top = (gb.Height - x.OutputTextBox.Height) / 2;

                    // add
                    tableLayoutPanel1.Controls.Add(gb, i + 1, rows);
                    rows++;
                }
            }
        }

        private void fillHiddenLayersOnValueChanged(decimal x)
        {
            decimal t = x - hiddenLayersLastValue;
            Console.WriteLine(t);

            if (t > 0)
            {
                for (int i = 0; i < t; ++i)
                {
                    var layer = new Tuple<MHiddenLayerHeader, MNeuronStack>(
                        new MHiddenLayerHeader(),
                        new MNeuronStack());
                    
                    hiddenLayers.LayerList.Add(layer);

                    lastColumn = (tableLayoutPanel1.ColumnCount += 1);
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));

                }
            }
            else if (t < 0)
            {
                for (decimal i = t; i < 0; ++i)
                {
                    lastColumn = (tableLayoutPanel1.ColumnCount -= 1);

                    hiddenLayers.LayerList.RemoveAt(hiddenLayers.LayerList.Count - 1);
                }
            }
        }

        private void regenerateHiddenLayers()
        {
            for (int i = 1; i < hiddenLayers.LayerList.Count; ++i)
            {
                var layerHeader = generateHiddenLayerHeader("Layer " + (i + 1), hiddenLayers.LayerList[i].Item1, (i+1).ToString());
                tableLayoutPanel1.Controls.Add(layerHeader, i + 1, 0);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fillHiddenLayersOnValueChanged(hiddenLayerUpDown.Value);

            regenerateTableOnValueChanged(new object(), new EventArgs());

            if (hiddenLayerUpDown.Value == 2)
            {
                hiddenLayers.LayerList[(int)hiddenLayerUpDown.Value - 1].Item1.Numeric.ValueChanged += layerChangedValue2;
            }
            if (hiddenLayerUpDown.Value == 3)
            {
                hiddenLayers.LayerList[(int)hiddenLayerUpDown.Value - 1].Item1.Numeric.ValueChanged += layerChangedValue3;

            }

            hiddenLayersLastValue = hiddenLayerUpDown.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compute(new object(), new EventArgs());
            //var s = new Neuron_1.Form1();
            //s.StartPosition = FormStartPosition.Manual;
            //Point location = MousePosition;
            //s.Top = location.Y - (s.Height / 2);
            //s.Left = location.X - (s.Width / 2);
            //s.Show();
        }

        // Generate Input
        //private FlowLayoutPanel generateInput(String text)
        //{
        //    var input = new FlowLayoutPanel();
        //    var label = new Label();
        //    label.Text = text;
        //    label.
        //}

        private void addInputOutput(MNeuronStack neuronStack, uint diff)
        {
            foreach (MNeuron x in neuronStack.Stack)
            {
                for (uint i = 0; i < diff; ++i)
                {
                    var input = 0.0m;
                    var weight = 0.0m;

                    x.Inputs.Add(input);
                    x.Weights.Add(weight);
                }
            }
        }

        private void removeInputOutput(MNeuronStack neuronStack, uint diff)
        {
            foreach (MNeuron x in neuronStack.Stack)
            {
                for (uint i = 0; i < diff; ++i)
                {
                    x.Inputs.RemoveAt(x.Inputs.Count - 1);
                    x.Weights.RemoveAt(x.Weights.Count - 1);
                }
            }
        }

        private void clearInputOutput(MNeuronStack neuronStack)
        {
            foreach (MNeuron x in neuronStack.Stack)
            {
                x.Inputs.Clear();
                //x.Weights.Clear();
            }
        }

        private void updateFirstLayerInputs()
        {
            var firstLayer = hiddenLayers.LayerList[0].Item2;

            //foreach (MNeuron x in firstLayer)
            //{
            //    //x.InputWeights.Clear();
            //    //x.Inputs.Clear();

            //    int i = 0;

            //    foreach (NumericUpDown z in inputsGenerationStack.Reverse())
            //    {
            //        //Console.WriteLine(x.Inputs.Count);
            //        x.Inputs[i] = z.Value;
            //        ++i;
            //    }
            //}
            var size = inputsGenerationStack.Count;

            clearInputOutput(firstLayer);
            addInputOutput(firstLayer, (uint)size);

            var list = inputsGenerationStack.Reverse().ToList();

            foreach (MNeuron x in firstLayer.Stack)
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    x.Inputs[i] = list[i].Value;
                }
            }
        }

        private void computeGlobalInput(MHiddenLayerHeader header, MNeuronStack neuronStack)
        {
            var inputFunction = header.InputFunction;

            foreach (MNeuron x in neuronStack.Stack)
            {
                x.GlobalInput = InputFunctions.computeGlobalInput(inputFunction, x);
                Console.WriteLine("test_input " + x.GlobalInput);
                Console.WriteLine(inputFunction);
            }
        }

        private void computeOutput(MHiddenLayerHeader header, MNeuronStack neuronStack)
        {
            foreach (MNeuron x in neuronStack.Stack)
            {
                x.Output = ActivationFunctions.computeOutput(header, x);
                Console.WriteLine("test_output " + x.Output);
                x.OutputTextBox.Text = x.Output.ToString();
            }
        }

        private void computeFirstLayerGIOutputs()
        {
            var firstLayer = hiddenLayers.LayerList[0].Item2;

            var header = hiddenLayers.LayerList[0].Item1;

            computeGlobalInput(header, firstLayer);
            computeOutput(header, firstLayer);
        }

        private void addInputsOutputsHiddenLayers(MNeuronStack from, MNeuronStack to)
        {
            var size = from.Stack.Count;

            clearInputOutput(to);
            addInputOutput(to, (uint)size);

            var list = from.Stack.Reverse().ToList<MNeuron>();

            foreach (MNeuron x in to.Stack)
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    x.Inputs[i] = list[i].Output;
                }
            }
        }

        private void ComputeHiddenLayers()
        {
            var end = hiddenLayers.LayerList.Count;

            for (int i = 1; i < end; ++i)
            {
                var layer = hiddenLayers.LayerList[i];
                var prev = hiddenLayers.LayerList[i - 1];

                addInputsOutputsHiddenLayers(prev.Item2, layer.Item2);
                computeGlobalInput(layer.Item1, layer.Item2);
                computeOutput(layer.Item1, layer.Item2);
            }
        }

        private void computeFinalOutput()
        {
            var layer = hiddenLayers.LayerList[hiddenLayers.LayerList.Count - 1];

            addInputsOutputsHiddenLayers(layer.Item2, outputLayer.Item2);
            computeGlobalInput(outputLayer.Item1, outputLayer.Item2);
            computeOutput(outputLayer.Item1, outputLayer.Item2);
        }

        public void Compute(object sender, EventArgs e)
        {
            updateFirstLayerInputs();
            computeFirstLayerGIOutputs();
            ComputeHiddenLayers();
            computeFinalOutput();
            //regenerateTableOnValueChanged(new object(), new EventArgs());
        }
    }
}
