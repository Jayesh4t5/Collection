using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Product : IComparable<Product>
    {
        private double price;
        private string name;
        public Product(double price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(Product other)// other --> hold data of Virat
        {
            // this keyword refers to Rohit's object
            // other will refers to Virat's object
            if (this.price< other.price)
            {
                return -1;
            }
            else if (this.price > other.price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{price} --> {name}";
        }
    }


}
