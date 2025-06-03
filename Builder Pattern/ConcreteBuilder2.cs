// ConcreteBuilder2.cs
namespace BuilderPattern
{
    public class ConcreteBuilder2 : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.AddPart("PartAX (from ConcreteBuilder2)");
        }

        public void BuildPartB()
        {
            product.AddPart("PartBY (from ConcreteBuilder2)");
        }

        public void BuildPartC()
        {
            // ConcreteBuilder2 might not build all parts
            // or build them differently
            product.AddPart("PartCZ (from ConcreteBuilder2)");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
