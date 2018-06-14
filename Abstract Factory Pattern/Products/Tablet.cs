namespace Abstract_Factory_Pattern
{
    public class Tablet : Device
    {
        private AbstractFactory _abstractFactory;

        public Tablet(AbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }

        public override void Assemble()
        {
            System.Console.WriteLine("Assembling... " + Name + "...");
            Cpu = _abstractFactory.BuildCPU();
            Gpu = _abstractFactory.BuildGPU();
            Motherboard = _abstractFactory.BuildMotherboard();
        }
    }
}
