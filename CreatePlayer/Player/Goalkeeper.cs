using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class Goalkeeper : Player
    {
        public Goalkeeper(Characteristics characteristics) : base(characteristics)
        {

        }
        public override string Do()
        {
            return "I can play by my hand and i should keep goal in safty";
        }
    }
}
