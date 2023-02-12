using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class CreateGoalkeeper : FabricCreatePlayer
    {
        public override Player CreatePlayer(Characteristics characteristics)
        {
            return new Goalkeeper(characteristics);
        }

        public override string GetFabricName()
        {
            return "Goalkeeper";
        }
    }
}
