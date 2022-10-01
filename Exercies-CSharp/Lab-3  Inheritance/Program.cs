using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static void Pizza()
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Dough")
                {
                    try
                    {
                        Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        Console.WriteLine("{0:f2}", dough.Callories());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else if (tokens[0] == "Topping")
                {
                    try
                    {
                        Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                        Console.WriteLine("{0:f2}", topping.Callories());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else
                {
                    string name = tokens[1];
                    int numberOfToppings = 0;
                    numberOfToppings = int.Parse(tokens[2]);
                    if (numberOfToppings > 10)
                    {
                        Console.WriteLine("Number of toppings should be in range [0..10].");
                        return;
                    }

                    command = Console.ReadLine();
                    tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    Pizza pizza;
                    try
                    {
                        Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        pizza = new Pizza(name, dough);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    for (int i = 0; i < numberOfToppings; i++)
                    {
                        command = Console.ReadLine();
                        tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                            pizza.AddTopping(topping);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }
                    Console.WriteLine("{0} - {1:F2} Calories.", pizza.Name, pizza.Callories());
                    return;
                }
                    command = Console.ReadLine();
            }
        }
        
        public static void ShoppingSpree()
        { 
            List<Person> _persons = new List<Person>(); 
            List<Product> _products = new List<Product>();

            try
            {
                string[] people = Console.ReadLine().Split(new []{';','='}, StringSplitOptions.RemoveEmptyEntries);
                string[] products = Console.ReadLine().Split(new []{';','='}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < people.Length; i+=2)
                {
                    string name = people[i];
                    decimal money = decimal.Parse(people[i + 1]);

                    Person person = new Person(name, money);
                
                    _persons.Add(person);
                }
            
                for (int i = 0; i < products.Length; i += 2)
                {
                    string name = products[i];
                    decimal cost = decimal.Parse(products[i + 1]);
 
                    Product product = new Product(name, cost);
 
                    _products.Add(product);
                }
            
                string purchase = Console.ReadLine();
 
                while (purchase != "END")
                {
                    string[] inputArguments = purchase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
 
                    Person person = _persons.FirstOrDefault(x => x.Name == inputArguments[0]);
                    Product product = _products.FirstOrDefault(y => y.Name == inputArguments[1]);
 
                    person.BuyProduct(product);
 
                    purchase = Console.ReadLine();
                }
 
                foreach (var element in _persons)
                {
                    Console.WriteLine(element);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void AnimalFarm()
        { var chickens = new List<Chicken>();
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var chicken = new Chicken( cmdArgs[0],
                        int.Parse(cmdArgs[1]));
                    chickens.Add(chicken);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            chickens.ForEach(p => Console.WriteLine(p.ToString()));
        }
        public static void Problem12()
        {
            var boxes = new List<Box>();
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var box = new Box(double.Parse(cmdArgs[0]),
                        double.Parse(cmdArgs[1]),
                        double.Parse(cmdArgs[2]));
                    boxes.Add(box);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            boxes.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}