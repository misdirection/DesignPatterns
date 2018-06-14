namespace Abstract_Factory_Pattern
{
    public class MacrohardFactory : AbstractFactory
    {
        public override ICPU BuildCPU() => new Floatel3770K();
        public override IGPU BuildGPU() => new MVideo999GT();
        public override IMotherboard BuildMotherboard() => new JESUSHyperY45();
    }
}
