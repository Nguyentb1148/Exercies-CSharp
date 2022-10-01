using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace Exercies4_CSharp
{
    public class BorderControl
    {
        private List<IRobot> robots;
        private List<ICitizen> citizens;
        private List<string> detainedIds;

        public BorderControl()
        {
            this.robots = new List<IRobot>();
            this.citizens = new List<ICitizen>();
            this.detainedIds = new List<string>();
        }

        public void AddCitizen(string name, int age, string id)
        {
            var citizen = new Citizen(name, age, id);
            this.citizens.Add(citizen);
            
        }
        
        public void AddRobot(string model, string id)
        {
            var robot = new Robot(model, id);
            this.robots.Add(robot);
        }

        
        public void AddDetainedIds(string match)
        {
            this.detainedIds.AddRange(this.citizens
                .Where(x => x.Id.EndsWith(match))
                .Select(y => y.Id)
                .ToList());

            this.detainedIds.AddRange(this.robots
                .Where(x => x.Id.EndsWith(match))
                .Select(y => y.Id)
                .ToList());
        }
        public string GetDetainedIds(string match)
        {
            var sb = new StringBuilder();
            this.detainedIds.Where(x => x.EndsWith(match)).ToList().ForEach(x => sb.AppendLine(x));
            return sb.ToString().TrimEnd();
        }
        
    }
}