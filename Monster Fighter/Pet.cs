using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Pet
    {
        private string name;
        private string breed;

        public Pet(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }


        public string Name
        {
            get { return name; }

            set {name = value;}
        }

       public string Breed
       {
           get { return breed; }

           set { breed = value; }
       }

        public virtual string MakeNoise()
        {
            return "Hello!";
        }

    }
}
