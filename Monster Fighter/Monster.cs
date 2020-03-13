using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Monster
    {
        private string type;
        private string name;
        private int attack;
        private int defence;
        private int health;

        public Monster(string type, string name, int attack, int defence, int health)
        {
            this.type = type;
            this.name = name;
            this.attack = attack;
            this.defence = defence;
            this.health = health;
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

        public int Attack
        {
            get { return attack; }

            set { Attack = value; }
        }

        public int Defence
        {
            get { return defence; }

            set { defence = value; }
        }

        public int Health
        {
            get { return health; }

            set { health = value; }
        }
    }
}
