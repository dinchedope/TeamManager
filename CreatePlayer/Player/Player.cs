using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePlayer
{
    public abstract class Player
    {
        protected Characteristics characteristics;

        public Player(Characteristics characteristics)
        {
            SetCharacteristics(characteristics);
        }
        public abstract string Do();
        
        public void SetCharacteristics(Characteristics characteristics)
        {
            this.characteristics = characteristics;
        }

        public Characteristics GetCharacteristics()
        {
            return characteristics;
        }

    }
}
