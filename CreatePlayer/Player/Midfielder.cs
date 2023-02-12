using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class Midfielder : Player
    {
        public Midfielder(Characteristics characteristics) : base(characteristics)
        {

        }
        public override string Do()
        {
            return "I play as defender and as forward.";
        }
    }
}
