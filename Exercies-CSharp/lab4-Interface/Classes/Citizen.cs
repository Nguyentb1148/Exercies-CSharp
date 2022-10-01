using Exercies4_CSharp.Interface;

namespace Exercies4_CSharp
{
    public class Citizen : ICitizen
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public  string Id { get; }
        public  string BirthDate { get; }
        
        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }
    }
}