namespace Decorator_Pattern
{
    public abstract class DungieGame
    {
        public virtual string Description { get; set; }
        public abstract double Price { get; }
    }
}
