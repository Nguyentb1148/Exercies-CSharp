namespace Exercies4_CSharp
{
    public class Robot: IRobot
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Model));
                this.model = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                this.id = value;
            }
        }
    }
}