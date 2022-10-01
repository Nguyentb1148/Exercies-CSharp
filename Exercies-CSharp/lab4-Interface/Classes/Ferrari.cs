using System.Text;
using Exercies4_CSharp.Interface;

namespace Exercies4_CSharp
{
    public class Ferrari: IFerrari
    {
        public string model;

        public string driver;
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }
        
        public string Model
        {
            get => this.model;
            private set
            {
                this.model = value;
            }
        }
        public string Driver
        {
            get => driver;
            set => driver = value;
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Model);
            sb.Append("/");
            sb.Append(this.Brakes());
            sb.Append("/");
            sb.Append(this.GasPedal());
            sb.Append("/");
            sb.Append(this.Driver);
            return sb.ToString();
        }
    }
}