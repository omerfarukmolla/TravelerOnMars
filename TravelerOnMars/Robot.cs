using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnMars
{
    public class Robot : RobotBase
    {
        public Robot(int x,int y, Diraction diraction)
        {
            Cordinate = new Cordinate(x, y);
            this.Diraction = diraction;
        }
        public Planet Planet { get; set; }
        public Cordinate Cordinate { get; set; }
        public Diraction Diraction { get; set; }

        public override (Cordinate, Diraction) Move(Command command)
        {
            int MinDirection = 0;
            int MaxDirect = 3;
            int direcInt = (int)this.Diraction;
            switch (command)
            {
                case Command.L:
                    direcInt++;
                    if (direcInt <= MaxDirect)
                    {
                        this.Diraction = (Diraction)direcInt;
                    }
                    else
                    {
                        this.Diraction = (Diraction)MinDirection;
                    }
                    break;
                case Command.R:
                    direcInt--;
                    if (direcInt >= MinDirection)
                    {
                        this.Diraction = (Diraction)direcInt;
                    }
                    else
                    {
                        this.Diraction = (Diraction)MaxDirect;
                    }
                    break;
                case Command.M:
                    Step(1);
                    break;
                default:
                    break;
            }


            return (this.Cordinate, this.Diraction);
        }

        protected override void Step(int count)
        {
            switch (this.Diraction)
            {
                case Diraction.N:
                    if (this.Cordinate.Y < Planet.Surface.Cordinate.Y)
                    {
                        this.Cordinate.Y += count;
                    }
                    break;
                case Diraction.W:
                    if (this.Cordinate.X > 0)
                    {
                        this.Cordinate.X -= count;
                    }
                    break;
                case Diraction.S:
                    if (this.Cordinate.Y > 0)
                    {
                        this.Cordinate.Y -= count;
                    }
                    break;
                case Diraction.E:
                    if (this.Cordinate.X < Planet.Surface.Cordinate.X)
                    {
                        this.Cordinate.X += count;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
