using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer_Perceptron.Models
{
    class MHiddenLayer
    {
        List<Tuple<MHiddenLayerHeader, MNeuronStack>> hiddenLayerList;

        public List<Tuple<MHiddenLayerHeader, MNeuronStack>> LayerList
        {
            get => hiddenLayerList;
        }

        public Tuple<MHiddenLayerHeader, MNeuronStack> GetLayerAt(int index)
        {
            return hiddenLayerList[index];
        }

        public MHiddenLayer()
        {
            hiddenLayerList = new List<Tuple<MHiddenLayerHeader, MNeuronStack>>();
            hiddenLayerList.Add(new Tuple<MHiddenLayerHeader, MNeuronStack>(
                new MHiddenLayerHeader(),
                new MNeuronStack()));
        }
    }
}
