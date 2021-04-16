using System;
using System.Collections.Generic;
using System.Text;

namespace ITWorkstationsInc.Model
{
    class RAMComponent
    {
        private int id;
        private string name;
        private double price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
