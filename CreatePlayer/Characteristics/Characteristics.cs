using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public class Characteristics
    {
        public int Pac;
        public int Sho;
        public int Pas;
        public int Dri;
        public int Def;
        public int Phy;

        public Characteristics(int pac, int sho, int pas, int dri, int def, int phy)
        {
            SetCharacteristic(pac, sho, pas, dri, def, phy);
        }
        
        public Characteristics()
        {

        }

        public void SetCharacteristic(int Pac, int Sho, int Pas, int Dri, int Def, int Phy)
        {
            this.Pac = Pac;
            this.Sho = Sho;
            this.Pas = Pas;
            this.Dri = Dri;
            this.Def = Def;
            this.Phy = Phy;
        }
    }
}
