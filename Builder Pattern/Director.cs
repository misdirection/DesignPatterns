// Director.cs
namespace BuilderPattern
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }

        // Optional: Construct with specific steps
        public void ConstructVariant(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            // Part C is not built in this variant
        }
    }
}
