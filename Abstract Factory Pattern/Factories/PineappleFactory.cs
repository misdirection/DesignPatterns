namespace Abstract_Factory_Pattern
{
    public class PineappleFactory : AbstractFactory
    {
        public override ICPU BuildCPU() => new BNEOctaCore69();
        public override IGPU BuildGPU() => new ATY6800X();
        public override IMotherboard BuildMotherboard() => new RockVIIIXtreme();
    }
}
