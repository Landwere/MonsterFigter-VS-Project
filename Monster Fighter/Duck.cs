using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Duck : Pet
    {
        public Duck(string name, string breed) : base(name, breed)
        {
        }

        public override string MakeNoise()
        {
            return "Quack, Quack!";
        }
    }
}
