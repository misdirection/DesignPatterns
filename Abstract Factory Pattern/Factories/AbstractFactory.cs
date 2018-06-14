namespace Abstract_Factory_Pattern
{
    public abstract class AbstractFactory
    {
        public abstract IGPU BuildGPU();
        public abstract ICPU BuildCPU();
        public abstract IMotherboard BuildMotherboard();
    }
}
