using Strategy_Pattern;
using Observer_Pattern;
using System;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Strategy Pattern*/
            Person swordsman = new Swordsman(new SwordBehaviour());
            Console.WriteLine("The swordsman is:");
            swordsman.Fight();
            Console.WriteLine();
            Person bowman = new Bowman(new BowBehaviour());
            Console.WriteLine("The bowman is:");
            bowman.Fight();

            bowman.SetWeapon(new KnifeBehaviour());
            Console.WriteLine("The bowman is:");
            bowman.Fight();
            Console.WriteLine();
            Console.WriteLine();

            /*Observer Pattern*/
            Newsticker newsticker = new Newsticker(); //Instance of subject
            SmartwatchDisplay smartwatchDisplay = new SmartwatchDisplay(newsticker); //instance of observer
            newsticker.RegisterObserver(smartwatchDisplay); //register observer to subject

            newsticker.SetNews("Breaking News! Hamburger Software does not sell burgers!"); //update news and notify observers

            Console.ReadLine();
        }
    }
}
