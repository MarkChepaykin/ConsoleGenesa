namespace Creature
{
    public class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Defence { get; set; }

        public Creature()
        {

        }

        public Creature(string name, int hp, int str, int spd, int def)
        {
            this.Name = name;
            this.Health = hp;
            this.Strength = str;
            this.Speed = spd;
            this.Defence = def;
        }

        public string GetInfo()
        {
            return $"{Name}, {Health}HP, {Strength} strength, {Speed} speed, {Defence} defence.";
        }



        public void Generate()
        {
            Random rnd = new Random();
            int maxHp = 101;
            int maxStr = 11;
            int maxSpd = 11;
            int maxDef = 7;

            // Stats roll
            int hp = rnd.Next(1, maxHp);
            int str = rnd.Next(1, maxStr);
            int spd = rnd.Next(1, maxSpd);
            int def = rnd.Next(1, maxDef);
            string name = CreatureName();

            string CreatureName()
            {
                string[] names = { "Vaporcat", "Emberling", "Decaywing", "Cursefigure", "Embertalon", "Brineword", "Abyssface", "Germling", "Decaycat", "Deadling", "Decayface",
                "Deadmutant", "Vaporfigure", "Germfigure", "Germman", "Embercat", "Vaportalon", "Vaportalon", "Germfigure", "Emberling", "Decaycat", "Abysstalon", "Cursefigure",
                "Vaporface", "Soilwing", "Soilmutant", "Germcat", "Abyssface", "Grossfigure", "Soilman", "Emberbug", "Vaporwing", "Vaporeyes", "Abyssman", "Webwing", "Abysseyes",
                "Brinetalon", "Ghostface", "Ghosteyes", "Ghostman", "Ghostman", "Brinebug", "Decaybug", "Grossword", "Emberface", "Grosseyes", "Ghostmutant", "Webword", "Abysseyes",
                "Soilbeast", "Soilling", "Soileyes", "Emberfigure", "Webfigure", "Abyssmutant", "Curseword", "Vaporface", "Abyssling", "Vaporwing", "Soilface", "Abyssmutant",
                "Abyssmutant", "Decayling", "Decayface", "Decayman", "Vaporword", "Germfigure", "Grossling", "Curseword", "Germwing", "Decaybug", "Embercat", "Curseman", "Grossword",
                "Cursetalon", "Emberwing", "Brinebeast", "Vaportalon", "Abysswing", "Brineman", "Ghostface", "Abyssword", "Emberword", "Vaporbug", "Deadfigure", "Germmutant",
                "Grosscat", "Abysscat", "Emberman", "Cursecat", "Vaporling", "Emberbug", "Deadmutant", "Germbeast", "Cursewing", "Germfigure", "Webling", "Grosscat", "Webcat",
                "Grossmutant", "Razormera", "Nighttoe", "Wispflesh", "Pikeclaw", "Rottingbane", "Poisontoe", "Poisonbane", "Taintbody", "Cursebane", "Taintbody", "Poisonflesh",
                "Curseflesh", "Razordra", "Curseclaw", "Rottingthroat", "Wispbody", "Gruethroat", "Poisontoe", "Razorling", "Blackeyes", "Bloodclaw", "Gruemoth", "Rottingthroat",
                "Tainteyes", "Rottingbody", "Gutfreak", "Poisonbeast", "Nightclaw", "Razorthroat", "Taintling", "Bloodling", "Razormera", "Cursemera", "Cursemoth", "Piketaur", "Wispclaw",
                "Wispeyes", "Nightlisk", "Curselisk", "Gutwing", "Cursebody", "Cursebane", "Nightdra", "Bloodeyes", "Poisonsome", "Razorlisk", "Bloodfreak", "Cursemera", "Pikewing", "Bloodmoth",
                "Grueflesh", "Rottingling", "Blackbody", "Pikelisk", "Wispsome", "Gruelisk", "Razorsome", "Pikeflesh", "Poisonwing", "Poisonbody", "Poisondra", "Rottingfreak", "Razorsome", "Wispmoth",
                "Wispmera", "Wisptaur", "Wispclaw", "Bloodflesh", "Gruebody", "Bloodlisk", "Nightlisk", "Piketoe", "Razorthroat", "Blackflesh", "Gutwing", "Cursethroat", "Blackthroat", "Blackeyes", "Taintsome",
                "Taintling", "Grueclaw", "Rottingtoe", "Gutbane", "Gruebeast", "Nightclaw", "Rottingthroat", "Blackthroat", "Taintdra", "Gruewing", "Cursebeast", "Blackfreak", "Razorbane", "Bloodfreak", "Blackfreak",
                "Cursebeast", "Taintlisk", "Poisonthroat", "Blackling", "Cursetaur", "Rottingeyes", "Cursedra", "Tainttoe", "Taintflesh", "Tainteyes", "Bloodwing", "Curseclaw", "Rottingfreak", "Poisonthroat", "Poisonling",
                "Taintbane", "Wisplisk", "Rottinglisk", "Wispclaw", "Wispbeast", "Razorlisk", "Pikeflesh", "Curseflesh" };

                int nameIndex = rnd.Next(names.Length);
                string name = names[nameIndex];
                return name;
            }

            Name = name;
            Health = hp;
            Strength = str;
            Speed = spd;
            Defence = def;
        }
    }




}
