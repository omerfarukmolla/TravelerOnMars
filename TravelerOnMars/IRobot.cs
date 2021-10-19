using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnMars
{
    public interface IRobot
    {
        public (Cordinate,Diraction) Move(Command command);
        
    }
    public abstract class RobotBase : IRobot
    {
        public abstract (Cordinate, Diraction) Move(Command command);

        protected abstract void Step(int count);
    }
}
