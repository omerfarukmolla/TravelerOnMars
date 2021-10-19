using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnMars
{
    public class Helpers
    {
       public bool CheckIsAnDirectory(string a)
        {
            if(a.Equals("N") || a.Equals("W") || a.Equals("E") || a.Equals("S") || a.Equals("n") || a.Equals("w") || a.Equals("e") || a.Equals("s"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Diraction stringToDiraction(string a)
        {
            if(a.Equals("n") || a.Equals("N"))
            {
                return Diraction.N;
            }
            else if(a.Equals("w") || a.Equals("W"))
            {
                return Diraction.W;
            }
            else if(a.Equals("E") || a.Equals("e"))
            {
                return Diraction.E;
            }
            else
            {
                return Diraction.S;
            }
            
        }

        public Command chrToCommand(char a)
        {   
            if(a.Equals('L') || a.Equals('l'))
            {
                return Command.L;
            }
            else if (a.Equals('R') || a.Equals('r'))
            {
                return Command.R;
            }
            else
            {
                return Command.M;
            }
        }
            
        public bool IsAviableCards(string a)
        {
            foreach (char chr in a)
            {
                if(!chr.Equals('R') && !chr.Equals('r'))
                {
                    if(!chr.Equals('L') && !chr.Equals('l'))
                    {
                        if (!chr.Equals('M') && !chr.Equals('m'))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}