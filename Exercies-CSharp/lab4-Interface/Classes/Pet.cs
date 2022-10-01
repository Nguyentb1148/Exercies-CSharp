using Exercies4_CSharp.lab4_Interface.Interface;

namespace Exercies4_CSharp
{
    public class Pet : IPet
    {
        public string Name { get;  }
        public  string BirthDate { get; }
        
        public Pet(string name,string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
    }
}