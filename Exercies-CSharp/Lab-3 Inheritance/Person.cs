using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<string>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be am empty string.");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            set
            {
                if (money<0)
                {
                    throw new ArgumentException("Money cannot a negative number");
                }
                money = value;
            }
        }

        public List<string> BagOfProducts
        {
            get => bagOfProducts;
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost >this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford{product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Money -= product.Cost;
                this.bagOfProducts.Add(product.Name);
            }
        }

        public override string ToString()
        {
            string person = $"{this.Name} - ";
            if (this.bagOfProducts.Count==0)
            {
                person += "Nothing bought ";
            }
            else
            {
                person += string.Join(",", this.bagOfProducts);
            }
            return person;
        }
        
    }
}