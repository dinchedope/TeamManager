using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class CreateMidfielder : FabricCreatePlayer
    {
        public override Player CreatePlayer(Characteristics characteristics)
        {
            return new Midfielder(characteristics);
        }

        public override string GetFabricName()
        {
            return "Midfielder";
        }
    }
}
