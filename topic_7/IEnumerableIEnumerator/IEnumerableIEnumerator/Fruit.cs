using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableIEnumerator
{
    public class Fruit
    {
        public readonly  string Name;
        public readonly double Weight;

        public Fruit(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return Name + " Вес:" + Weight;
        }
    }
}
