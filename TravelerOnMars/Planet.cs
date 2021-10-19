using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnMars
{
    public class Planet : IPlanet
    {
        public Planet(Surface surface)
        {
            this.Surface = surface;
        }
        public Surface Surface { get; set; }
        public List<Robot> Robots { get; set; }

        public int AddRobot(Robot robot)
        {
            robot.Planet = this;
            Robots.Add(robot);
            return this.Robots.IndexOf(robot);
        }
    }
}
