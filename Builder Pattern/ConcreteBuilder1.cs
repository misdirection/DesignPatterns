// ConcreteBuilder1.cs
namespace BuilderPattern
{
    public class ConcreteBuilder1 : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.AddPart("PartA1 (from ConcreteBuilder1)");
        }

        public void BuildPartB()
        {
            product.AddPart("PartB1 (from ConcreteBuilder1)");
        }

        public void BuildPartC()
        {
            product.AddPart("PartC1 (from ConcreteBuilder1)");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
