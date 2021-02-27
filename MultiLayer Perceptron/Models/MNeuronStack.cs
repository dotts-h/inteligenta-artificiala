using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer_Perceptron.Models
{
    class MNeuronStack
    {
        Stack<MNeuron> neuronStack;

        public Stack<MNeuron> Stack
        {
            get => neuronStack;
        }

        public MNeuronStack()
        {
            neuronStack = new Stack<MNeuron>();
            neuronStack.Push(new MNeuron());
        }
    }
}
