using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomDemo
{
    public class Atom
    {
        public string name;
        public string symbol;
        public int proton;
        public int neutron;
        public double weight;
        public Atom()
        {

        }
        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            this.name = name;
            this.proton = proton;
            this.neutron = neutron;
            this.weight = weight;
            this.symbol = symbol;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", name, proton, neutron, weight, symbol);
        }
        public static Atom Parse(string line)
        {
            string[] value = line.Split(' ');

            try
            {
                if (value.Length != 5)
                {
                    throw new Exception("Error!!!");
                }
                else
                {
                    string name = value[0];
                    string proton = value[1];
                    string neutron = value[2];
                    string weight = value[3];
                    string symbol = value[4];
                    Atom result = new Atom(name, Convert.ToInt32(proton), Convert.ToInt32(neutron), Convert.ToDouble(weight), symbol);
                    return result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}

