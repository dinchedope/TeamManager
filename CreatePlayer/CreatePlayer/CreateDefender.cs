using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class CreateDefender : FabricCreatePlayer
    {
        public override Player CreatePlayer(Characteristics characteristics)
        {
            return new Defender(characteristics);
        }
        public override string GetFabricName()
        {
            return "Defender";
        }
    }
}
