using System;
using System.Collections.Generic;

namespace PizzaStore2
{
    public class FastFood
    {
        List<string> FastFoodMenu;

        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        public FastFood()
        {
            Id = 0;
            Name = "";
            Price = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
