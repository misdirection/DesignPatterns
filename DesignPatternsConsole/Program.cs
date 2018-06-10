using Strategy_Pattern;
using Observer_Pattern;
using System;
using Decorator_Pattern;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Strategy Pattern*/
            Console.WriteLine("Output for strategy pattern: \n");
            Person swordsman = new Swordsman(new SwordBehaviour());
            Console.WriteLine("The swordsman is:");
            swordsman.Fight();
            Console.WriteLine();
            Person bowman = new Bowman(new BowBehaviour());
            Console.WriteLine("The bowman is:");
            bowman.Fight();
            Console.WriteLine();
            bowman.SetWeapon(new KnifeBehaviour());
            Console.WriteLine("The bowman is:");
            bowman.Fight();
            Console.WriteLine();
            Console.WriteLine("______________________________________________________________________________");

            /*Observer Pattern*/
            Console.WriteLine("Output for observer pattern: \n");
            Newsticker newsticker = new Newsticker(); //Instance of subject
            SmartwatchDisplay smartwatchDisplay = new SmartwatchDisplay(newsticker); //instance of observer
            newsticker.RegisterObserver(smartwatchDisplay); //register observer to subject

            newsticker.SetNews("Breaking News! Hamburger Software does not sell burgers!"); //update news and notify observers
            Console.WriteLine("______________________________________________________________________________");

            /*Decorator Pattern*/
            Console.WriteLine("Output for decorator pattern: \n");
            DungieGame dungieGame = new Worstiny();
            Console.WriteLine(dungieGame.Description + "\nPrice: " + dungieGame.Price + "Euro");
            Console.WriteLine();
            dungieGame = new GoodDLC(dungieGame);
            Console.WriteLine(dungieGame.Description + "\nPrice: " + dungieGame.Price + "Euro");
            Console.WriteLine();
            dungieGame = new EvenBetterDLC(dungieGame);
            Console.WriteLine(dungieGame.Description + "\nPrice: " + dungieGame.Price + "Euro");
            Console.ReadLine();
        }
    }
}
