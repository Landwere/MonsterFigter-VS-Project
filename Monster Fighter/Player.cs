using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Fighter
{
    class Player
    {
        private string name;
        private int score;
        private int health;
        private int lives;
        private Weapon weapon;
        private Armour armour;

        public Player(string name, int health, int score, int lives)
        {
            this.name = name;
            this.score = score;
            this.health = health;
            this.lives = lives;
            weapon = null; //no weapon when charecter first created
            this.armour = null;
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int Score
        {
            get { return score; }

            set { score = value; }
        }

        public int Health
        {
            get { return health; }

            set { health = value; }
        }

        public int Lives
        {
            get { return lives; }

            set { lives = value; }
        }
        public int ChangeScore
        {
            set { score = score + value; }
        }

        public int ChangeHealth
        {
            set { health = health + value; }
        }

        public int ChangeLives
        {
            set { lives = lives + value; }
        }

        public Weapon Weapon
        {
            get { return weapon; }

            set { weapon = value; }
        }

        public Armour Armour
        {
            get { return armour; }

            set { armour = value; }
        }
    }
}
