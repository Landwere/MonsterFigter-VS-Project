using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Armour : Item
    {
        private int defencePower;

        public Armour(string type, string name, int defencePower) : base(type,name)
        {
            this.defencePower = defencePower;
        }

        public int DefencePower
        {
            get { return defencePower; }

            set { defencePower = value; }
        }
    }
}
