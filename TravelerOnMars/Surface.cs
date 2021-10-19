using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnMars
{
    public class Surface
    {
        public Surface(int x,int y)
        {
            this.Cordinate = new Cordinate(x, y);
        }
        public Cordinate Cordinate{ get; set; }
    }
}
