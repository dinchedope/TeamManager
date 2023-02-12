using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class Defender : Player
    {
        public Defender(Characteristics characteristics) : base(characteristics)
        {

        }
        public override string Do()
        {
            return "My task is defend the football goal";
        }
    }
}
