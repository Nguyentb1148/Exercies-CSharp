using System;
using System.Linq;
using Exercies4_CSharp.Interface;

namespace Exercies4_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
        }

        public static void BorderControl()
        {
            var borderControl = new BorderControl();
            
            var input = Console.ReadLine();
            
            while (input != "End")
            {
                try
                {
                    var inputArgs = input.Split();
                    var memberType = inputArgs[0];
                    int wordCount = 0, index = 0;

                    // skip whitespace until first word
                    while (index < input.Length && char.IsWhiteSpace(input[index]))
                        index++;
                    while (index < input.Length)
                    {
                        // check if current char is part of a word
                        while (index < input.Length && !char.IsWhiteSpace(input[index]))
                            index++;

                        wordCount++;

                        // skip whitespace until next word
                        while (index < input.Length && char.IsWhiteSpace(input[index]))
                            index++;
                    }

                    if (wordCount==3)
                    {
                        borderControl.AddCitizen(inputArgs[0],int.Parse(inputArgs[1]),inputArgs[2]);
                    }
                    else
                    {
                        borderControl.AddRobot(inputArgs[0],inputArgs[1]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
                input = Console.ReadLine();
            }
            
            var matchId = Console.ReadLine();
            borderControl.AddDetainedIds(matchId);
            Console.WriteLine(borderControl.GetDetainedIds(matchId));
        }
        public static void Telephony()
        {
            var smartphone = new Smartphone();

            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            try
            {
                numbers.ToList().ForEach(x => Console.WriteLine(smartphone.Call(x)));
                urls.ToList().ForEach(x => Console.WriteLine(smartphone.Browse(x)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Ferrari()
        {
            string driverName = Console.ReadLine();

            var ferrari = new Ferrari(driverName);

            Console.WriteLine(ferrari);
        }
        // public static void MultipleImplementation()
        // {
        //     string name = Console.ReadLine();
        //     int age = int.Parse(Console.ReadLine());
        //     string id = Console.ReadLine();
        //     string birthdate = Console.ReadLine();
        //     IIdentifiable identifiable = new Citizen(name, age,id, birthdate);
        //     IBirthable birthable = new Citizen(name, age, id, birthdate);
        //     Console.WriteLine("-----------");
        //     Console.WriteLine(identifiable.Id);
        //     Console.WriteLine(birthable.BirthDate);
        // }
    }
}

// public static void Person()
// {
//     string name = Console.ReadLine();
//     int age = int.Parse(Console.ReadLine());
//     IPerson person = new Citizen(name, age);
//     Console.WriteLine("----------------");
//     Console.WriteLine(person.Name);
//     Console.WriteLine(person.Age);
// }
// public static void Shape()
// {
//     var radius = int.Parse(Console.ReadLine());
//     IDrawable circle = new Circle(radius);
//
//     var width = int.Parse(Console.ReadLine());
//     var height = int.Parse(Console.ReadLine());
//     IDrawable rect = new Rectangle(width, height);
//
//     circle.Draw();
//     rect.Draw();
// }
//
// public static void Cars()
// {
//     ICar seat = new Seat("Leon", "Grey");
//     ICar tesla = new Tesla("Model 3", "Red", 2);
//
//     Console.WriteLine(seat.ToString());
//     Console.WriteLine(tesla.ToString());
//
// }