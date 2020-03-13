using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Fighter
{
    public partial class Form1 : Form
    {
        List<Player> players = new List<Player>();
        List<Monster> monsters = new List<Monster>();
        List<Weapon> weapons = new List<Weapon>();
        List<Armour> armour = new List<Armour>();

        int playerDisplayed = 0;
        int currentMonster;

        private void GenerateRandomMonsterNumber()
        {
            Random rnd = new Random();
            currentMonster = rnd.Next(0, monsters.Count());
        }

        private void DisplayCurrentMonster()
        {
            Image monsterImage = Image.FromFile("Monster Images\\" + monsters[currentMonster].Type + ".jpg.jpg");
            pictureBoxMonster.Image = monsterImage;

            textBoxMonsterNameAndType.Text = monsters[currentMonster].Name + " The " + monsters[currentMonster].Type;
            textBoxMonsterHealth.Text = Convert.ToString(monsters[currentMonster].Health);
            textBoxMonsterDefence.Text = Convert.ToString(monsters[currentMonster].Defence);
            textBoxMonsterAttack.Text = Convert.ToString(monsters[currentMonster].Attack);
        }

        private void DisplayData()
        {
            textBoxPlayerName.Text = players[playerDisplayed].Name;
            textBoxPlayerHealth.Text = players[playerDisplayed].Health.ToString();
            textBoxPlayerScore.Text = players[playerDisplayed].Score.ToString();
            textBoxPlayerLives.Text = players[playerDisplayed].Lives.ToString();

            if (players[playerDisplayed].Weapon == null )
            {
                textBoxWeaponName.Text = "None";
                textBoxWeaponType.Text = "N/A";
                textBoxWeaponAttackPower.Text = "N/A";
            }
            else
            {
                textBoxWeaponName.Text = players[playerDisplayed].Weapon.Name;
                textBoxWeaponType.Text = players[playerDisplayed].Weapon.Type;
                textBoxWeaponAttackPower.Text = players[playerDisplayed].Weapon.AttackPower.ToString();
            }

            if (players[playerDisplayed].Armour == null)
            {
                textBoxArmourName.Text = "None";
                textBoxArmourType.Text = "N/A";
                textBoxDefencePower.Text = "N/A";
            }
            else
            {
                textBoxArmourName.Text = players[playerDisplayed].Armour.Name;
                textBoxArmourType.Text = players[playerDisplayed].Armour.Type;
                textBoxDefencePower.Text = players[playerDisplayed].Armour.DefencePower.ToString();
            }
        }
           
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Player list

            players.Add(new Player("Arthur", 100, 0, 3));

            players.Add(new Player("Random", 75, 5, 5));

            players.Add(new Player("Ford", 100, 35, 3));
            
            players.Add(new Player("Cory", 10, 0, 1));

            players.Add(new Player("NotCory", 101, 0, 6));

            players.Add(new Player("No1", 500, 0, 1));

            //Monster list

            monsters.Add(new Monster("Bat", "Big Bat", 10, 5, 25));
            monsters.Add(new Monster("Zombie", "Brian", 25, 30, 100));
            monsters.Add(new Monster("Frog", "Yargle", 300, 10, 150));
            monsters.Add(new Monster("Robot", "Rob", 150, 50, 200));
            monsters.Add(new Monster("Stalker", "Shrike", 500, 500, 800));
            monsters.Add(new Monster("Bandit", "Bill", 30, 20, 75));
            monsters.Add(new Monster("Cube", "Cube", 16, 16, 16));
            monsters.Add(new Monster("Pirate", "Pete", 40, 10, 100));
            monsters.Add(new Monster("Dragon", "Doug", 200, 100, 900));
            monsters.Add(new Monster("Elf", "Wizard", 80, 5, 100));
            monsters.Add(new Monster("void", "'  '", 800, 200, 850));
            monsters.Add(new Monster("Spider", "Replicator", 50, 20, 60));
            monsters.Add(new Monster("DogZombie", "Doug2", 30, 5, 50));
            monsters.Add(new Monster("Wall", "Stone wall", 0, 100, 800));
            monsters.Add(new Monster("Ghost", "Archer", 90, 15, 70));
            monsters.Add(new Monster("ShapeShifter", "Shifty", 100, 50, players[playerDisplayed].Health));
            monsters.Add(new Monster("Skeleton", "Jones Bones", 30, 50, 100));
            monsters.Add(new Monster("GhostOf", "LNTV", 40, 15, 200));
            monsters.Add(new Monster("Expendable", "Guard", 10, 15, 50));
            monsters.Add(new Monster("Giant", "Crab", 80, 100, 500));
            monsters.Add(new Monster("Big", "Boss", 650, 100, 800));

            GenerateRandomMonsterNumber();
            DisplayCurrentMonster();

            //Weapon list

            weapons.Add(new Weapon("Gun", "Bubblegun", 1));
            weapons.Add(new Weapon("Nuckles", "Wooden knuckles", 1));
            weapons.Add(new Weapon("Wand", "Create water", 1));
            weapons.Add(new Weapon("Stick", "Small Stick", 1));
            weapons.Add(new Weapon("Stick", "Big Stick", 2));
            weapons.Add(new Weapon("Branch", "large Branch", 2));
            weapons.Add(new Weapon("Knuckles", "Brass knuckles", 2));
            weapons.Add(new Weapon("Slingshot", "Wooded Slingshot", 2));
            weapons.Add(new Weapon("Kuckles", "Spiked Knuckles", 2));
            weapons.Add(new Weapon("Sword", "Dagger", 2));
            weapons.Add(new Weapon("Gun", "nailgun", 3));
            weapons.Add(new Weapon("Bow", "Shortbow", 3));
            weapons.Add(new Weapon("Wand", "Tragic missile", 3));
            weapons.Add(new Weapon("Spear", "Short Spear", 3));
            weapons.Add(new Weapon("Sword", "Regularsword", 3));
            weapons.Add(new Weapon("Sword", "Longsword", 5));
            weapons.Add(new Weapon("Sword", "Diamond Sword", 6));
            weapons.Add(new Weapon("Wand", "Fireball", 6));
            weapons.Add(new Weapon("Hammer", "Wall Breaker", 7));
            weapons.Add(new Weapon("Axe", "Titan chopper", 7));
            weapons.Add(new Weapon("Dagger", "Deaths balde", 8));

            //Armour list

            armour.Add(new Armour("Helmet", "Bucket", 0));
            armour.Add(new Armour("Shield", "Buckler of Hope", 1));
            armour.Add(new Armour("Ring", "Ring of protection +1", 1));
            armour.Add(new Armour("Amulet", "Amulet of protection +1)", 1));
            armour.Add(new Armour("Armour", "Wooded Armour", 1));
            armour.Add(new Armour("Shield", "Buckler of iron", 2));
            armour.Add(new Armour("Shield", "Small Sheild", 2));
            armour.Add(new Armour("Magic", "Mage Armour", 2));
            armour.Add(new Armour("Armour", "Leather Armour", 2));
            armour.Add(new Armour("Amulet", "Magic Glass", 2));
            armour.Add(new Armour("Shield", "Buckler of better", 3));
            armour.Add(new Armour("ring", "Protection from blue", 3));
            armour.Add(new Armour("Armour", "Scale mail", 5));
            armour.Add(new Armour("Sheild", "Scale Shield", 5));
            armour.Add(new Armour("Magic", "Orb of protection", 5));
            armour.Add(new Armour("Stone", "Of magical defence", 6));      
            armour.Add(new Armour("Shield", "Tower Shield", 8));
            armour.Add(new Armour("Armour", "Full plate", 9));
            armour.Add(new Armour("Armour", "DragonScale", 9));
            armour.Add(new Armour("Amulet", "Braclet of meteor protection", 10));


            DisplayData();
            

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            playerDisplayed++;

            if (playerDisplayed == players.Count())
            {
                playerDisplayed = 0;
            }
            DisplayData();

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            playerDisplayed--;

            if (playerDisplayed == -1)
            {
                playerDisplayed = players.Count() -1;
            }
            DisplayData();

        }

        private void textBoxPlayerLives_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIncreseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = 100;

            DisplayData();
        }

        private void buttonDecreseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = -100;

            DisplayData();
        }

        private void buttonIncreseHealth_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeHealth = 50;

            DisplayData();
        }

        private void buttonDecreseHealth_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeHealth = -50;

            DisplayData();
        }

        private void buttonIncreseLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = 1;

            DisplayData();
        }

        private void buttonDecreseLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = -1;

            DisplayData();
        }

        private void buttonGenerateRandomWeapon_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomWeaponNumber = rnd.Next(0, weapons.Count());

            DialogResult result = MessageBox.Show(weapons[randomWeaponNumber].Type + " Found!" +
                Environment.NewLine + "\nIt's called the " + weapons[randomWeaponNumber].Name +
                Environment.NewLine + "\nAttack Power " + weapons[randomWeaponNumber].AttackPower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to equip it?", "Weapon Found", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Weapon = weapons[randomWeaponNumber];
            }

            DisplayData();

        }

        private void buttonWeaponDrop_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Weapon = null;

            DisplayData();
        }

        private void buttonGenerateArmour_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomArmourNumber = rnd.Next(0, armour.Count());

            DialogResult result = MessageBox.Show(armour[randomArmourNumber].Type + " Found!" +
                Environment.NewLine + "\nIt's called the " + armour[randomArmourNumber].Name +
                Environment.NewLine + "\nDefence Power " + armour[randomArmourNumber].DefencePower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to equip it?", "Armour Found", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Armour = armour[randomArmourNumber];
            }

            DisplayData();
        }

        private void buttonDropArmour_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Armour = null;

            DisplayData();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet myPet = new Pet("Dave", "Generic");

            MessageBox.Show(myPet.MakeNoise() +
                "I am a " + myPet.Breed +
                " Pet and my name is " + myPet.Name);
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Dave 1", "Wobbler");

            MessageBox.Show(myDog.MakeNoise() +
                "I am a " + myDog.Breed +
                " Dog and my name is " + myDog.Name);
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Dave 2", "Slouch");

            MessageBox.Show(myCat.MakeNoise() +
                "I am a " + myCat.Breed +
                " Cat and my name is " + myCat.Name);
        }

        private void buttonDuck_Click(object sender, EventArgs e)
        {
            Duck myDuck = new Duck("Dave 3", "Mallard");

                MessageBox.Show(myDuck.MakeNoise() +
                "I am a " + myDuck.Breed +
                " Duck and my name is " + myDuck.Name); 
        }

        private void buttonPlayerAttack_Click(object sender, EventArgs e)
        {
            int hitPower = 10;

            if (players[playerDisplayed].Weapon != null)
            {
                hitPower = 10 * players[playerDisplayed].Weapon.AttackPower;
            }

            monsters[currentMonster].Health = monsters[currentMonster].Health - hitPower;

            players[playerDisplayed].ChangeScore = hitPower;

            if (monsters[currentMonster].Health <= 0)
            {
                MessageBox.Show("Congratulations! You have killed " + monsters[currentMonster].Name +
                    " the " + monsters[currentMonster].Type + " :)");

                MessageBox.Show("Get ready for the next monster!");

                GenerateRandomMonsterNumber();

            }

            DisplayCurrentMonster();
            DisplayData();
        }

        private void buttonPlayerRun_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int grabChance = rnd.Next(0, 4);

            if (grabChance == 3)
            {
                int healthLost = monsters[currentMonster].Attack / 10;

                if (players[playerDisplayed].Armour != null)
                {
                    healthLost = healthLost / players[playerDisplayed].Armour.DefencePower;
                }

                if (players[playerDisplayed].Health - healthLost <= 0)
                {
                    players[playerDisplayed].Health = 0;
                }
                else
                {
                    players[playerDisplayed].Health = players[playerDisplayed].Health - healthLost;
                }
                DisplayData();

                MessageBox.Show("As you were running away, the " + monsters[currentMonster].Type +
                    " grabbed you! And you have lost " + healthLost + " health! :(");
            }

            if (players[playerDisplayed].Health != 0)
            {
                GenerateRandomMonsterNumber();
                DisplayCurrentMonster();
            }
            else
            {
                MessageBox.Show("GAME OVER!!!" + Environment.NewLine + Environment.NewLine +
                    "you have died, unfortunately!");
            }



            GenerateRandomMonsterNumber();
            DisplayCurrentMonster();
        }
    }
}
