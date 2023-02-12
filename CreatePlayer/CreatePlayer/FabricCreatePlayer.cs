using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public abstract class FabricCreatePlayer
    {
        public string Name;
        public abstract Player CreatePlayer(Characteristics characteristics);
        public abstract string GetFabricName();
    }
}
