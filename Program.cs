using Creature;

using System.Media;

namespace Creature
{
    using BattleManager;
    public class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer welcomeMusic = new SoundPlayer("welcomeMusic.wav");
                welcomeMusic.Load();
                //welcomeMusic.Play();
            }

            string logo = @"


 ▄████▄   ▒█████   ███▄    █   ██████  ▒█████   ██▓    ▓█████      ▄████ ▓█████  ███▄    █ ▓█████   ██████  ▄▄▄      
▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██    ▒ ▒██▒  ██▒▓██▒    ▓█   ▀     ██▒ ▀█▒▓█   ▀  ██ ▀█   █ ▓█   ▀ ▒██    ▒ ▒████▄    
▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒░ ▓██▄   ▒██░  ██▒▒██░    ▒███      ▒██░▄▄▄░▒███   ▓██  ▀█ ██▒▒███   ░ ▓██▄   ▒██  ▀█▄  
▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒  ▒   ██▒▒██   ██░▒██░    ▒▓█  ▄    ░▓█  ██▓▒▓█  ▄ ▓██▒  ▐▌██▒▒▓█  ▄   ▒   ██▒░██▄▄▄▄██ 
▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░▒██████▒▒░ ████▓▒░░██████▒░▒████▒   ░▒▓███▀▒░▒████▒▒██░   ▓██░░▒████▒▒██████▒▒ ▓█   ▓██▒
░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ▒ ▒▓▒ ▒ ░░ ▒░▒░▒░ ░ ▒░▓  ░░░ ▒░ ░    ░▒   ▒ ░░ ▒░ ░░ ▒░   ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░ ▒▒   ▓▒█░
    ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░░ ░▒  ░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ░ ░  ░     ░   ░  ░ ░  ░░ ░░   ░ ▒░ ░ ░  ░░ ░▒  ░ ░  ▒   ▒▒ ░
░        ░ ░ ░ ▒     ░   ░ ░ ░  ░  ░  ░ ░ ░ ▒    ░ ░      ░      ░ ░   ░    ░      ░   ░ ░    ░   ░  ░  ░    ░   ▒   
░ ░          ░ ░           ░       ░      ░ ░      ░  ░   ░  ░         ░    ░  ░         ░    ░  ░      ░        ░  ░
░                                                                                                                    
                                                                                                                     
                                                                                                                     
        ";
            Console.WriteLine(logo);


            Console.WriteLine("Wandering down your path you find yourself investigating an unknown cavern.");
            Console.WriteLine("Passing a few narrow crevices you end up in a poorly lit room with a mystrious device in the center.");




            Creature myCreature = new Creature();
            myCreature.Generate();

            Console.WriteLine("The machine consists of a glass cylinder and a massive stone console at the bottom.");
            Console.WriteLine("You realise that you are at the Genesa. A place where creatures were made by the \"Old ones\".");
            Console.WriteLine("On the console there is only a single button. You cannot resist the urge to press it");
            Console.WriteLine("(Press the button)");
            Console.ReadLine();

            Console.WriteLine("As soon as the button is pressed the strange device starts emmanating light. In a flash, a creature is formed inside of it");
            Console.WriteLine("You lean down to take a closer look. Some bscure symbols light up on the glass.");
            Console.WriteLine("The longer you look, the more familiar they become, until you realise that they are starting to make sense.");
            Console.WriteLine($"It reads: \"{myCreature.GetInfo()}\".");
            Console.WriteLine("Would you press the button again, to see a different creature?");
            
            BattleManager battleManager = new BattleManager();
            battleManager.Start();


            Creature newCreature = new Creature();

            Creature enemyCreature = new Creature();
            enemyCreature.Generate();

            Console.WriteLine("You leave the Genesa.");
            Console.ReadLine();
            Console.WriteLine("As you go down the road you hear some rustling coming from the bushes up ahead.");

            Console.WriteLine($"Coming closer to investigate {newCreature.Name} notices something coming towards you.");
            Console.WriteLine($"It's an enemy {enemyCreature.Name}, get ready for a fight!");

            battleManager.Fight();

            Console.ReadLine();


        }

        // create a method that would return a creature with randomized values and bring it to the loop


    }
}