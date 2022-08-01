namespace BattleManager
{
    using Creature;

    public class BattleManager
    {

        public Creature myCreature { get; set; }
        public Creature enemyCreature { get; set; }

        public void Start()
        {

            Creature newCreature = new Creature();
            newCreature.Generate();
            // creature roller loop
            bool loopRoll = false;
            do
            {
                Console.Write("Roll again? (y/n): ");
                string roll = Console.ReadLine();

                switch (roll)
                {
                    case "y":
                        newCreature.Generate();

                        Console.WriteLine("Another creature appears.");
                        Console.WriteLine($"It is called the {newCreature.Name}, it has {newCreature.Health}HP, {newCreature.Strength} strength and {newCreature.Speed} speed");
                        loopRoll = true;
                        break;
                    case "n":
                        Console.WriteLine($"You carefully lift the glass hood and take {newCreature.Name} out of it.");
                        Console.WriteLine("It belongs to you now.");
                        loopRoll = false;
                        break;
                    default:
                        Console.WriteLine("What?");
                        loopRoll = true;
                        break;
                }
            }
            while (loopRoll != false);
        }

        public void Fight()
        {

            int myDmg = myCreature.Strength * (100 / (100 + enemyCreature.Defence));
            int enemyDmg = enemyCreature.Strength* (100 / (100 + myCreature.Defence));

            while (myCreature.Health > 0 && enemyCreature.Health > 0)
            {
                if (myCreature.Speed >= enemyCreature.Speed)
                {
                    Console.WriteLine($"Your {myCreature.Name} atacks enemy {enemyCreature.Name}!");
                    Console.WriteLine($"It deals {myDmg}.");
                }
                else
                {
                    Console.WriteLine($"{enemyCreature.Name} attacks your {myCreature.Name}"!);
                    Console.WriteLine($"It deals {enemyDmg}.");
                }
            }
            
        }

    }
}

