using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Soft
{
    public class Product1
    {
        int id;
        string name;
        double price;
        public int Id
        {
            set { id = value; }
            get { return id; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public string printProduct1()
        {
            return $" id is {id}\n name is {name}\nprice is{price}";

        }

        


    }
}
