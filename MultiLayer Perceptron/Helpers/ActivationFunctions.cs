using MultiLayer_Perceptron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer_Perceptron.Helpers
{
    class ActivationFunctions
    {
        static public decimal treapta(decimal gi, decimal t)
        {
            if (gi < t)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static public decimal sigmoidala(decimal gi, decimal g, decimal t)
        {
            decimal _exp = -(g * (gi - t));
            decimal _den = 1 + (decimal)Math.Pow(Math.E, (double)_exp);

            return (1 / _den);
        }

        static public decimal signum(decimal gi, decimal g, decimal t)
        {
            if (gi < t)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        static public decimal tanH(decimal gi, decimal g, decimal t)
        {
            decimal _expPoz = g * (gi - t);
            decimal _expNeg = -(g * (gi - t));
            decimal _e_to_poz = (decimal)Math.Pow(Math.E, (double)_expPoz);
            decimal _e_to_neg = (decimal)Math.Pow(Math.E, (double)_expNeg);
            decimal _num = _e_to_poz - _e_to_neg;
            decimal _den = _e_to_poz + _e_to_neg;

            return (_num / _den);
        }

        static public decimal rampa(decimal gi, decimal a, decimal t)
        {
            var gii = gi - t;

            if (gii < -a)
            {
                return -1;
            }
            else if (gii > a)
            {
                return 1;
            }
            else
            {
                return (gii / a);
            }
        }

        static public decimal computeOutput(MHiddenLayerHeader header, MNeuron neuron)
        {
            var function = header.ActivationFunction;
            var gi = neuron.GlobalInput;
            decimal t = 0;

            if (function.Equals("Treapta"))
            {
                t = treapta(gi, header.Theta);
                return t;
                //t = Decimal.Parse(activationTextBox.Text);
            }
            if (function.Equals("Sigmoidala"))
            {
                if (header.IsBinary)
                {
                    decimal o = sigmoidala(gi, header.G, header.Theta);
                    //decimal o = Decimal.Parse(activationTextBox.Text);

                    if (o < 0.5m)
                    {
                        t = 0;
                    }
                    else
                    {
                        t = 1;
                    }

                    return t;
                }
                else
                {
                    t = sigmoidala(gi, header.G, header.Theta);
                    return t;
                }
            }
            if (function.Equals("Signum"))
            {
                t = signum(gi, header.G, header.Theta);
                //t = Decimal.Parse(activationTextBox.Text);
                return t;
            }
            if (function.Equals("TanH"))
            {
                if (header.IsBinary)
                {
                    decimal o = tanH(gi, header.G, header.Theta);
                    //decimal o = Decimal.Parse(activationTextBox.Text);

                    if (o < 0)
                    {
                        t = -1;
                    }
                    else
                    {
                        t = 1;
                    }

                    return t;
                }
                else
                {
                    t = tanH(gi, header.G, header.Theta);
                    return t;
                }
            }
            if (function.Equals("Rampa"))
            {
                if (header.IsBinary)
                {
                    decimal o = rampa(gi, header.A, header.Theta);
                    //decimal o = Decimal.Parse(activationTextBox.Text);

                    if (o < 0)
                    {
                        t = -1;
                    }
                    else
                    {
                        t = 1;
                    }

                    return t;
                }
                else
                {
                    t = rampa(gi, header.A, header.Theta);
                }
            }

            //outputTextBox.Text = t.ToString();
            return -1;
        }
    }
}
