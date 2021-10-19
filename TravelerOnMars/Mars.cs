using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnMars
{
    public class Mars : Planet
    {
        public Mars(Surface surface) :base(surface)
        {
            Robots = new List<Robot>();
        }
        
    }
}
