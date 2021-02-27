using MultiLayer_Perceptron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLayer_Perceptron.Helpers
{
    class InputFunctions
    {
        static public decimal sum(MNeuron neuron)
        {
            //var inputs_weights = neuron.InputWeights;
            var inputs = neuron.Inputs;
            var weights = neuron.Weights;
            var end = neuron.Inputs.Count;
            decimal t = 0;

            for (int i = 0; i < end; ++i)
            {
                t += (inputs[i] * weights[i]);
            }
            //foreach (Tuple<decimal, decimal> x in inputs_weights)
            //{
            //    var v = x.Item1;
            //    t += (v * x.Item2);
            //}

            return t;
        }

        static public decimal product(MNeuron neuron)
        {
            var inputs = neuron.Inputs;
            var weights = neuron.Weights;
            var end = neuron.Inputs.Count;
            decimal t = 1;

            for (int i = 0; i < end; ++i)
            {
                t *= (inputs[i] * weights[i]);
            }

            return t;
        }

        static public decimal min(MNeuron neuron)
        {
            var inputs = neuron.Inputs;
            var weights = neuron.Weights;
            var end = neuron.Inputs.Count;
            decimal v1 = inputs[0];
            decimal v2 = weights[0];
            decimal t = v1 * v2;

            for (int i = 1; i < end; ++i)
            {
                decimal z = inputs[i] * weights[i];
                if (z < t)
                {
                    t = z;
                }
            }

            return t;
        }

        static public decimal max(MNeuron neuron)
        {
            var inputs = neuron.Inputs;
            var weights = neuron.Weights;
            var end = neuron.Inputs.Count;
            decimal v1 = inputs[0];
            decimal v2 = weights[0];
            decimal t = v1 * v2;

            for (int i = 1; i < end; ++i)
            {
                decimal z = inputs[i] * weights[i];
                if (z > t)
                {
                    t = z;
                }
            }

            return t;
        }

        static public decimal computeGlobalInput(String function, MNeuron neuron)
        {
            if (function.Equals("Sum"))
            {
                return sum(neuron);
            }
            if (function.Equals("Product"))
            {
                return product(neuron);
            }
            if (function.Equals("Min"))
            {
                return min(neuron);
            }
            if (function.Equals("Max"))
            {
                return max(neuron);
            }

            return -1;
        }
    }
}
