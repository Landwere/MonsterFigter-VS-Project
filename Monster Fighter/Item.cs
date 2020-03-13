using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Item
    {
        private string type;
        private string name;

        public Item(string type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public string Type
        {
            get { return type; }

            set { type = value; }
        }

        public string Name
        {
            get { return name; }

            set { type = value; }
        }
    }
}
