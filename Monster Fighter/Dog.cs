using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Dog : Pet
    {

        public Dog(string name, string breed) : base(name, breed)
        {

        }

        public override string MakeNoise()
        {
            return "Woof, Woof!";
        }
    }
}
