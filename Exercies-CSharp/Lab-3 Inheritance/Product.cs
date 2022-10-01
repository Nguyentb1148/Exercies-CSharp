using System;

namespace ConsoleApplication1
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                };
                name=value;
            }
        }

        public decimal Cost
        {
            get => cost;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
        }
    }
}