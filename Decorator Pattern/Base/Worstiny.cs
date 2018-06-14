namespace Decorator_Pattern
{
    public class Worstiny : DungieGame
    {
        public Worstiny() => Description = "Game: Worstiny - Worst game of 2017!\nDLCs included:";
        public override double Price => 99.99d;
    }
}
