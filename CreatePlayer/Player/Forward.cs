using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreatePlayer
{
    public class Forward : Player
    {
        public Forward(Characteristics characteristics) : base(characteristics)
        {

        }
        public override string Do()
        {
            return "I play in forward side. My main task is score goals";
        }
    }
}
