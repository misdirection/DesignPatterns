﻿using Strategy_Pattern;
using Observer_Pattern;
using Decorator_Pattern;
using Singleton_Pattern;
using Factory_Method_Pattern;
using Abstract_Factory_Pattern;
using System;
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
            Person archer = new Archer(new BowBehaviour());
            Console.WriteLine("The archer is:");
            archer.Fight();
            Console.WriteLine();
            archer.SetWeapon(new KnifeBehaviour());
            Console.WriteLine("The archer is:");
            archer.Fight();
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
            Console.WriteLine("______________________________________________________________________________");

            /*Factory Method Pattern*/
            Console.WriteLine("Output for factory method pattern: \n");
            DeviceFactory factory = new DeviceFactory();
            Factory_Method_Pattern.IDevice device = factory.MakeDevice(Factory_Method_Pattern.DeviceType.PC);
            Console.WriteLine("Factory created device:");
            Console.WriteLine(device.Name);
            Console.WriteLine();
            Console.WriteLine("______________________________________________________________________________");

            /*Abstract Factory Pattern*/
            Console.WriteLine("Output for abstract factory pattern: \n");
      
            AbstractStore yStore = new YStore();
            Device pineappleSmartphone = yStore.OrderDevice(Abstract_Factory_Pattern.DeviceType.Smartphone);
            Console.WriteLine("Peter received his " + pineappleSmartphone.Name + "!");
            Console.WriteLine();

            AbstractStore jupiterStore = new JupiterStore();

            Device macroComputer = jupiterStore.OrderDevice(Abstract_Factory_Pattern.DeviceType.Computer);
            Console.WriteLine("Chris received his " + macroComputer.Name + "!");
            Console.WriteLine("______________________________________________________________________________");

            /*Singleton Pattern*/
            Console.WriteLine("Output for singleton pattern: \n");
            BasicSingleton basicSingleton = BasicSingleton.CreateInstance;
            Console.WriteLine(basicSingleton.Text);
            

            Console.ReadLine();
        }
    }
}
