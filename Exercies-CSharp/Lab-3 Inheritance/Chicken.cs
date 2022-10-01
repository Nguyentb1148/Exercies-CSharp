using System;

namespace ConsoleApplication1.Properties
{
    public class Chicken
    {
        private string name;
        private int age;
        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name=value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value>15||value<0)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                age=value;
            }
        }
        public override string ToString()
        {
            return $"Chicken {Name} ( age {Age}) can produce 1 egg per day";
        }
    }
}