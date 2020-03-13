namespace Monster_Fighter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPlayerScore = new System.Windows.Forms.TextBox();
            this.textBoxPlayerHealth = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxPlayerLives = new System.Windows.Forms.TextBox();
            this.labelPlayerLives = new System.Windows.Forms.Label();
            this.buttonIncreseScore = new System.Windows.Forms.Button();
            this.buttonDecreseScore = new System.Windows.Forms.Button();
            this.buttonIncreseHealth = new System.Windows.Forms.Button();
            this.buttonDecreseHealth = new System.Windows.Forms.Button();
            this.buttonIncreseLives = new System.Windows.Forms.Button();
            this.buttonDecreseLives = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon = new System.Windows.Forms.GroupBox();
            this.textBoxWeaponAttackPower = new System.Windows.Forms.TextBox();
            this.textBoxWeaponType = new System.Windows.Forms.TextBox();
            this.textBoxWeaponName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWeaponType = new System.Windows.Forms.Label();
            this.labelWeaponName = new System.Windows.Forms.Label();
            this.buttonWeaponDrop = new System.Windows.Forms.Button();
            this.buttonGenerateRandomWeapon = new System.Windows.Forms.Button();
            this.groupBoxArmour = new System.Windows.Forms.GroupBox();
            this.textBoxArmourName = new System.Windows.Forms.TextBox();
            this.textBoxArmourType = new System.Windows.Forms.TextBox();
            this.textBoxDefencePower = new System.Windows.Forms.TextBox();
            this.labelArmourDefence = new System.Windows.Forms.Label();
            this.labelArmourType = new System.Windows.Forms.Label();
            this.labelArmourName = new System.Windows.Forms.Label();
            this.buttonDropArmour = new System.Windows.Forms.Button();
            this.buttonGenerateArmour = new System.Windows.Forms.Button();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonDog = new System.Windows.Forms.Button();
            this.buttonCat = new System.Windows.Forms.Button();
            this.buttonDuck = new System.Windows.Forms.Button();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.textBoxMonsterNameAndType = new System.Windows.Forms.TextBox();
            this.textBoxMonsterHealth = new System.Windows.Forms.TextBox();
            this.textBoxMonsterAttack = new System.Windows.Forms.TextBox();
            this.textBoxMonsterDefence = new System.Windows.Forms.TextBox();
            this.buttonPlayerRun = new System.Windows.Forms.Button();
            this.buttonPlayerAttack = new System.Windows.Forms.Button();
            this.labelMonsterHealth = new System.Windows.Forms.Label();
            this.labelMonsterAttack = new System.Windows.Forms.Label();
            this.labelMonsterDefence = new System.Windows.Forms.Label();
            this.groupBoxCurrentWeapon.SuspendLayout();
            this.groupBoxArmour.SuspendLayout();
            this.groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlayerScore
            // 
            this.textBoxPlayerScore.Location = new System.Drawing.Point(85, 82);
            this.textBoxPlayerScore.Name = "textBoxPlayerScore";
            this.textBoxPlayerScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerScore.TabIndex = 1;
            // 
            // textBoxPlayerHealth
            // 
            this.textBoxPlayerHealth.Location = new System.Drawing.Point(85, 56);
            this.textBoxPlayerHealth.Name = "textBoxPlayerHealth";
            this.textBoxPlayerHealth.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerHealth.TabIndex = 2;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(85, 26);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Health:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Score:";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(12, 133);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 11;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(110, 133);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxPlayerLives
            // 
            this.textBoxPlayerLives.Location = new System.Drawing.Point(85, 110);
            this.textBoxPlayerLives.Name = "textBoxPlayerLives";
            this.textBoxPlayerLives.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerLives.TabIndex = 13;
            this.textBoxPlayerLives.TextChanged += new System.EventHandler(this.textBoxPlayerLives_TextChanged);
            // 
            // labelPlayerLives
            // 
            this.labelPlayerLives.AutoSize = true;
            this.labelPlayerLives.Location = new System.Drawing.Point(24, 113);
            this.labelPlayerLives.Name = "labelPlayerLives";
            this.labelPlayerLives.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerLives.TabIndex = 14;
            this.labelPlayerLives.Text = "Lives:";
            // 
            // buttonIncreseScore
            // 
            this.buttonIncreseScore.Location = new System.Drawing.Point(254, 51);
            this.buttonIncreseScore.Name = "buttonIncreseScore";
            this.buttonIncreseScore.Size = new System.Drawing.Size(75, 34);
            this.buttonIncreseScore.TabIndex = 15;
            this.buttonIncreseScore.Text = "Increase Score";
            this.buttonIncreseScore.UseVisualStyleBackColor = true;
            this.buttonIncreseScore.Click += new System.EventHandler(this.buttonIncreseScore_Click);
            // 
            // buttonDecreseScore
            // 
            this.buttonDecreseScore.Location = new System.Drawing.Point(254, 92);
            this.buttonDecreseScore.Name = "buttonDecreseScore";
            this.buttonDecreseScore.Size = new System.Drawing.Size(75, 34);
            this.buttonDecreseScore.TabIndex = 16;
            this.buttonDecreseScore.Text = "Decrese Score";
            this.buttonDecreseScore.UseVisualStyleBackColor = true;
            this.buttonDecreseScore.Click += new System.EventHandler(this.buttonDecreseScore_Click);
            // 
            // buttonIncreseHealth
            // 
            this.buttonIncreseHealth.Location = new System.Drawing.Point(335, 51);
            this.buttonIncreseHealth.Name = "buttonIncreseHealth";
            this.buttonIncreseHealth.Size = new System.Drawing.Size(75, 34);
            this.buttonIncreseHealth.TabIndex = 17;
            this.buttonIncreseHealth.Text = "Increase Health";
            this.buttonIncreseHealth.UseVisualStyleBackColor = true;
            this.buttonIncreseHealth.Click += new System.EventHandler(this.buttonIncreseHealth_Click);
            // 
            // buttonDecreseHealth
            // 
            this.buttonDecreseHealth.Location = new System.Drawing.Point(335, 92);
            this.buttonDecreseHealth.Name = "buttonDecreseHealth";
            this.buttonDecreseHealth.Size = new System.Drawing.Size(75, 34);
            this.buttonDecreseHealth.TabIndex = 18;
            this.buttonDecreseHealth.Text = "Decrese Health";
            this.buttonDecreseHealth.UseVisualStyleBackColor = true;
            this.buttonDecreseHealth.Click += new System.EventHandler(this.buttonDecreseHealth_Click);
            // 
            // buttonIncreseLives
            // 
            this.buttonIncreseLives.Location = new System.Drawing.Point(416, 51);
            this.buttonIncreseLives.Name = "buttonIncreseLives";
            this.buttonIncreseLives.Size = new System.Drawing.Size(75, 34);
            this.buttonIncreseLives.TabIndex = 19;
            this.buttonIncreseLives.Text = "Increase Lives";
            this.buttonIncreseLives.UseVisualStyleBackColor = true;
            this.buttonIncreseLives.Click += new System.EventHandler(this.buttonIncreseLives_Click);
            // 
            // buttonDecreseLives
            // 
            this.buttonDecreseLives.Location = new System.Drawing.Point(416, 91);
            this.buttonDecreseLives.Name = "buttonDecreseLives";
            this.buttonDecreseLives.Size = new System.Drawing.Size(75, 34);
            this.buttonDecreseLives.TabIndex = 20;
            this.buttonDecreseLives.Text = "Decrese Lives";
            this.buttonDecreseLives.UseVisualStyleBackColor = true;
            this.buttonDecreseLives.Click += new System.EventHandler(this.buttonDecreseLives_Click);
            // 
            // groupBoxCurrentWeapon
            // 
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponAttackPower);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponType);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponName);
            this.groupBoxCurrentWeapon.Controls.Add(this.label6);
            this.groupBoxCurrentWeapon.Controls.Add(this.labelWeaponType);
            this.groupBoxCurrentWeapon.Controls.Add(this.labelWeaponName);
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonWeaponDrop);
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonGenerateRandomWeapon);
            this.groupBoxCurrentWeapon.Location = new System.Drawing.Point(12, 190);
            this.groupBoxCurrentWeapon.Name = "groupBoxCurrentWeapon";
            this.groupBoxCurrentWeapon.Size = new System.Drawing.Size(230, 129);
            this.groupBoxCurrentWeapon.TabIndex = 21;
            this.groupBoxCurrentWeapon.TabStop = false;
            this.groupBoxCurrentWeapon.Text = "Current Weapon";
            // 
            // textBoxWeaponAttackPower
            // 
            this.textBoxWeaponAttackPower.Location = new System.Drawing.Point(78, 65);
            this.textBoxWeaponAttackPower.Name = "textBoxWeaponAttackPower";
            this.textBoxWeaponAttackPower.Size = new System.Drawing.Size(132, 20);
            this.textBoxWeaponAttackPower.TabIndex = 7;
            // 
            // textBoxWeaponType
            // 
            this.textBoxWeaponType.Location = new System.Drawing.Point(78, 41);
            this.textBoxWeaponType.Name = "textBoxWeaponType";
            this.textBoxWeaponType.Size = new System.Drawing.Size(132, 20);
            this.textBoxWeaponType.TabIndex = 6;
            // 
            // textBoxWeaponName
            // 
            this.textBoxWeaponName.Location = new System.Drawing.Point(78, 15);
            this.textBoxWeaponName.Name = "textBoxWeaponName";
            this.textBoxWeaponName.Size = new System.Drawing.Size(132, 20);
            this.textBoxWeaponName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Attack Power:";
            // 
            // labelWeaponType
            // 
            this.labelWeaponType.AutoSize = true;
            this.labelWeaponType.Location = new System.Drawing.Point(6, 44);
            this.labelWeaponType.Name = "labelWeaponType";
            this.labelWeaponType.Size = new System.Drawing.Size(34, 13);
            this.labelWeaponType.TabIndex = 3;
            this.labelWeaponType.Text = "Type:";
            // 
            // labelWeaponName
            // 
            this.labelWeaponName.AutoSize = true;
            this.labelWeaponName.Location = new System.Drawing.Point(6, 18);
            this.labelWeaponName.Name = "labelWeaponName";
            this.labelWeaponName.Size = new System.Drawing.Size(38, 13);
            this.labelWeaponName.TabIndex = 2;
            this.labelWeaponName.Text = "Name:";
            // 
            // buttonWeaponDrop
            // 
            this.buttonWeaponDrop.Location = new System.Drawing.Point(149, 100);
            this.buttonWeaponDrop.Name = "buttonWeaponDrop";
            this.buttonWeaponDrop.Size = new System.Drawing.Size(75, 23);
            this.buttonWeaponDrop.TabIndex = 1;
            this.buttonWeaponDrop.Text = "Drop";
            this.buttonWeaponDrop.UseVisualStyleBackColor = true;
            this.buttonWeaponDrop.Click += new System.EventHandler(this.buttonWeaponDrop_Click);
            // 
            // buttonGenerateRandomWeapon
            // 
            this.buttonGenerateRandomWeapon.Location = new System.Drawing.Point(6, 88);
            this.buttonGenerateRandomWeapon.Name = "buttonGenerateRandomWeapon";
            this.buttonGenerateRandomWeapon.Size = new System.Drawing.Size(105, 35);
            this.buttonGenerateRandomWeapon.TabIndex = 0;
            this.buttonGenerateRandomWeapon.Text = "Generate Random Weapon";
            this.buttonGenerateRandomWeapon.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomWeapon.Click += new System.EventHandler(this.buttonGenerateRandomWeapon_Click);
            // 
            // groupBoxArmour
            // 
            this.groupBoxArmour.Controls.Add(this.textBoxArmourName);
            this.groupBoxArmour.Controls.Add(this.textBoxArmourType);
            this.groupBoxArmour.Controls.Add(this.textBoxDefencePower);
            this.groupBoxArmour.Controls.Add(this.labelArmourDefence);
            this.groupBoxArmour.Controls.Add(this.labelArmourType);
            this.groupBoxArmour.Controls.Add(this.labelArmourName);
            this.groupBoxArmour.Controls.Add(this.buttonDropArmour);
            this.groupBoxArmour.Controls.Add(this.buttonGenerateArmour);
            this.groupBoxArmour.Location = new System.Drawing.Point(21, 325);
            this.groupBoxArmour.Name = "groupBoxArmour";
            this.groupBoxArmour.Size = new System.Drawing.Size(200, 137);
            this.groupBoxArmour.TabIndex = 22;
            this.groupBoxArmour.TabStop = false;
            this.groupBoxArmour.Text = "Current Armour";
            // 
            // textBoxArmourName
            // 
            this.textBoxArmourName.Location = new System.Drawing.Point(92, 19);
            this.textBoxArmourName.Name = "textBoxArmourName";
            this.textBoxArmourName.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmourName.TabIndex = 7;
            // 
            // textBoxArmourType
            // 
            this.textBoxArmourType.Location = new System.Drawing.Point(92, 45);
            this.textBoxArmourType.Name = "textBoxArmourType";
            this.textBoxArmourType.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmourType.TabIndex = 6;
            // 
            // textBoxDefencePower
            // 
            this.textBoxDefencePower.Location = new System.Drawing.Point(92, 71);
            this.textBoxDefencePower.Name = "textBoxDefencePower";
            this.textBoxDefencePower.Size = new System.Drawing.Size(100, 20);
            this.textBoxDefencePower.TabIndex = 5;
            // 
            // labelArmourDefence
            // 
            this.labelArmourDefence.AutoSize = true;
            this.labelArmourDefence.Location = new System.Drawing.Point(6, 74);
            this.labelArmourDefence.Name = "labelArmourDefence";
            this.labelArmourDefence.Size = new System.Drawing.Size(84, 13);
            this.labelArmourDefence.TabIndex = 4;
            this.labelArmourDefence.Text = "Defence Power:";
            // 
            // labelArmourType
            // 
            this.labelArmourType.AutoSize = true;
            this.labelArmourType.Location = new System.Drawing.Point(27, 48);
            this.labelArmourType.Name = "labelArmourType";
            this.labelArmourType.Size = new System.Drawing.Size(34, 13);
            this.labelArmourType.TabIndex = 3;
            this.labelArmourType.Text = "Type:";
            // 
            // labelArmourName
            // 
            this.labelArmourName.AutoSize = true;
            this.labelArmourName.Location = new System.Drawing.Point(27, 22);
            this.labelArmourName.Name = "labelArmourName";
            this.labelArmourName.Size = new System.Drawing.Size(38, 13);
            this.labelArmourName.TabIndex = 2;
            this.labelArmourName.Text = "Name:";
            // 
            // buttonDropArmour
            // 
            this.buttonDropArmour.Location = new System.Drawing.Point(119, 108);
            this.buttonDropArmour.Name = "buttonDropArmour";
            this.buttonDropArmour.Size = new System.Drawing.Size(75, 23);
            this.buttonDropArmour.TabIndex = 1;
            this.buttonDropArmour.Text = "Drop";
            this.buttonDropArmour.UseVisualStyleBackColor = true;
            this.buttonDropArmour.Click += new System.EventHandler(this.buttonDropArmour_Click);
            // 
            // buttonGenerateArmour
            // 
            this.buttonGenerateArmour.Location = new System.Drawing.Point(0, 96);
            this.buttonGenerateArmour.Name = "buttonGenerateArmour";
            this.buttonGenerateArmour.Size = new System.Drawing.Size(98, 41);
            this.buttonGenerateArmour.TabIndex = 0;
            this.buttonGenerateArmour.Text = "Generate Random Armour";
            this.buttonGenerateArmour.UseVisualStyleBackColor = true;
            this.buttonGenerateArmour.Click += new System.EventHandler(this.buttonGenerateArmour_Click);
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.textBoxPlayerName);
            this.groupBoxPlayer.Controls.Add(this.textBoxPlayerHealth);
            this.groupBoxPlayer.Controls.Add(this.label3);
            this.groupBoxPlayer.Controls.Add(this.label4);
            this.groupBoxPlayer.Controls.Add(this.textBoxPlayerScore);
            this.groupBoxPlayer.Controls.Add(this.label5);
            this.groupBoxPlayer.Controls.Add(this.labelPlayerLives);
            this.groupBoxPlayer.Controls.Add(this.textBoxPlayerLives);
            this.groupBoxPlayer.Controls.Add(this.buttonNext);
            this.groupBoxPlayer.Controls.Add(this.buttonPrevious);
            this.groupBoxPlayer.Location = new System.Drawing.Point(21, 22);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(200, 162);
            this.groupBoxPlayer.TabIndex = 23;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player";
            // 
            // buttonPet
            // 
            this.buttonPet.Location = new System.Drawing.Point(254, 161);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(75, 23);
            this.buttonPet.TabIndex = 24;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // buttonDog
            // 
            this.buttonDog.Location = new System.Drawing.Point(254, 190);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(75, 23);
            this.buttonDog.TabIndex = 25;
            this.buttonDog.Text = "Dog";
            this.buttonDog.UseVisualStyleBackColor = true;
            this.buttonDog.Click += new System.EventHandler(this.buttonDog_Click);
            // 
            // buttonCat
            // 
            this.buttonCat.Location = new System.Drawing.Point(254, 219);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(75, 23);
            this.buttonCat.TabIndex = 26;
            this.buttonCat.Text = "Cat";
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonDuck
            // 
            this.buttonDuck.Location = new System.Drawing.Point(254, 248);
            this.buttonDuck.Name = "buttonDuck";
            this.buttonDuck.Size = new System.Drawing.Size(75, 23);
            this.buttonDuck.TabIndex = 27;
            this.buttonDuck.Text = "Duck";
            this.buttonDuck.UseVisualStyleBackColor = true;
            this.buttonDuck.Click += new System.EventHandler(this.buttonDuck_Click);
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMonster.Location = new System.Drawing.Point(497, 22);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(275, 275);
            this.pictureBoxMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonster.TabIndex = 28;
            this.pictureBoxMonster.TabStop = false;
            // 
            // textBoxMonsterNameAndType
            // 
            this.textBoxMonsterNameAndType.Location = new System.Drawing.Point(497, 309);
            this.textBoxMonsterNameAndType.Name = "textBoxMonsterNameAndType";
            this.textBoxMonsterNameAndType.Size = new System.Drawing.Size(275, 20);
            this.textBoxMonsterNameAndType.TabIndex = 29;
            // 
            // textBoxMonsterHealth
            // 
            this.textBoxMonsterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMonsterHealth.Location = new System.Drawing.Point(641, 342);
            this.textBoxMonsterHealth.Name = "textBoxMonsterHealth";
            this.textBoxMonsterHealth.Size = new System.Drawing.Size(131, 23);
            this.textBoxMonsterHealth.TabIndex = 30;
            // 
            // textBoxMonsterAttack
            // 
            this.textBoxMonsterAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMonsterAttack.Location = new System.Drawing.Point(641, 368);
            this.textBoxMonsterAttack.Name = "textBoxMonsterAttack";
            this.textBoxMonsterAttack.Size = new System.Drawing.Size(131, 23);
            this.textBoxMonsterAttack.TabIndex = 31;
            // 
            // textBoxMonsterDefence
            // 
            this.textBoxMonsterDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMonsterDefence.Location = new System.Drawing.Point(641, 397);
            this.textBoxMonsterDefence.Name = "textBoxMonsterDefence";
            this.textBoxMonsterDefence.Size = new System.Drawing.Size(131, 23);
            this.textBoxMonsterDefence.TabIndex = 32;
            // 
            // buttonPlayerRun
            // 
            this.buttonPlayerRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPlayerRun.Location = new System.Drawing.Point(641, 425);
            this.buttonPlayerRun.Name = "buttonPlayerRun";
            this.buttonPlayerRun.Size = new System.Drawing.Size(131, 37);
            this.buttonPlayerRun.TabIndex = 33;
            this.buttonPlayerRun.Text = "Run";
            this.buttonPlayerRun.UseVisualStyleBackColor = true;
            this.buttonPlayerRun.Click += new System.EventHandler(this.buttonPlayerRun_Click);
            // 
            // buttonPlayerAttack
            // 
            this.buttonPlayerAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPlayerAttack.Location = new System.Drawing.Point(497, 425);
            this.buttonPlayerAttack.Name = "buttonPlayerAttack";
            this.buttonPlayerAttack.Size = new System.Drawing.Size(131, 37);
            this.buttonPlayerAttack.TabIndex = 34;
            this.buttonPlayerAttack.Text = "Attack";
            this.buttonPlayerAttack.UseVisualStyleBackColor = true;
            this.buttonPlayerAttack.Click += new System.EventHandler(this.buttonPlayerAttack_Click);
            // 
            // labelMonsterHealth
            // 
            this.labelMonsterHealth.AutoSize = true;
            this.labelMonsterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMonsterHealth.Location = new System.Drawing.Point(529, 347);
            this.labelMonsterHealth.Name = "labelMonsterHealth";
            this.labelMonsterHealth.Size = new System.Drawing.Size(60, 20);
            this.labelMonsterHealth.TabIndex = 35;
            this.labelMonsterHealth.Text = "Health:";
            // 
            // labelMonsterAttack
            // 
            this.labelMonsterAttack.AutoSize = true;
            this.labelMonsterAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMonsterAttack.Location = new System.Drawing.Point(530, 373);
            this.labelMonsterAttack.Name = "labelMonsterAttack";
            this.labelMonsterAttack.Size = new System.Drawing.Size(59, 20);
            this.labelMonsterAttack.TabIndex = 36;
            this.labelMonsterAttack.Text = "Attack:";
            // 
            // labelMonsterDefence
            // 
            this.labelMonsterDefence.AutoSize = true;
            this.labelMonsterDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMonsterDefence.Location = new System.Drawing.Point(515, 397);
            this.labelMonsterDefence.Name = "labelMonsterDefence";
            this.labelMonsterDefence.Size = new System.Drawing.Size(74, 20);
            this.labelMonsterDefence.TabIndex = 37;
            this.labelMonsterDefence.Text = "Defence:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.labelMonsterDefence);
            this.Controls.Add(this.labelMonsterAttack);
            this.Controls.Add(this.labelMonsterHealth);
            this.Controls.Add(this.buttonPlayerAttack);
            this.Controls.Add(this.buttonPlayerRun);
            this.Controls.Add(this.textBoxMonsterDefence);
            this.Controls.Add(this.textBoxMonsterAttack);
            this.Controls.Add(this.textBoxMonsterHealth);
            this.Controls.Add(this.textBoxMonsterNameAndType);
            this.Controls.Add(this.pictureBoxMonster);
            this.Controls.Add(this.buttonDuck);
            this.Controls.Add(this.buttonCat);
            this.Controls.Add(this.buttonDog);
            this.Controls.Add(this.buttonPet);
            this.Controls.Add(this.groupBoxPlayer);
            this.Controls.Add(this.groupBoxArmour);
            this.Controls.Add(this.groupBoxCurrentWeapon);
            this.Controls.Add(this.buttonDecreseLives);
            this.Controls.Add(this.buttonIncreseLives);
            this.Controls.Add(this.buttonDecreseHealth);
            this.Controls.Add(this.buttonIncreseHealth);
            this.Controls.Add(this.buttonDecreseScore);
            this.Controls.Add(this.buttonIncreseScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCurrentWeapon.ResumeLayout(false);
            this.groupBoxCurrentWeapon.PerformLayout();
            this.groupBoxArmour.ResumeLayout(false);
            this.groupBoxArmour.PerformLayout();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPlayerScore;
        private System.Windows.Forms.TextBox textBoxPlayerHealth;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxPlayerLives;
        private System.Windows.Forms.Label labelPlayerLives;
        private System.Windows.Forms.Button buttonIncreseScore;
        private System.Windows.Forms.Button buttonDecreseScore;
        private System.Windows.Forms.Button buttonIncreseHealth;
        private System.Windows.Forms.Button buttonDecreseHealth;
        private System.Windows.Forms.Button buttonIncreseLives;
        private System.Windows.Forms.Button buttonDecreseLives;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeapon;
        private System.Windows.Forms.TextBox textBoxWeaponAttackPower;
        private System.Windows.Forms.TextBox textBoxWeaponType;
        private System.Windows.Forms.TextBox textBoxWeaponName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelWeaponType;
        private System.Windows.Forms.Label labelWeaponName;
        private System.Windows.Forms.Button buttonWeaponDrop;
        private System.Windows.Forms.Button buttonGenerateRandomWeapon;
        private System.Windows.Forms.GroupBox groupBoxArmour;
        private System.Windows.Forms.TextBox textBoxArmourName;
        private System.Windows.Forms.TextBox textBoxArmourType;
        private System.Windows.Forms.TextBox textBoxDefencePower;
        private System.Windows.Forms.Label labelArmourDefence;
        private System.Windows.Forms.Label labelArmourType;
        private System.Windows.Forms.Label labelArmourName;
        private System.Windows.Forms.Button buttonDropArmour;
        private System.Windows.Forms.Button buttonGenerateArmour;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Button buttonPet;
        private System.Windows.Forms.Button buttonDog;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button buttonDuck;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.TextBox textBoxMonsterNameAndType;
        private System.Windows.Forms.TextBox textBoxMonsterHealth;
        private System.Windows.Forms.TextBox textBoxMonsterAttack;
        private System.Windows.Forms.TextBox textBoxMonsterDefence;
        private System.Windows.Forms.Button buttonPlayerRun;
        private System.Windows.Forms.Button buttonPlayerAttack;
        private System.Windows.Forms.Label labelMonsterHealth;
        private System.Windows.Forms.Label labelMonsterAttack;
        private System.Windows.Forms.Label labelMonsterDefence;
    }
}

