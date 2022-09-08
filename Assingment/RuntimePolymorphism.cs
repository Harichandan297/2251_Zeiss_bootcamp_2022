namespace ConsoleApp16
{

    class TataCar
    {
        //Dependency
        Engine _engine = new RevtronEngine(); //composition
        //Engine _engine = new VericoreEngine();
        //Engine _engine = new KrytoechEngine();
        public void Ignite()
        {
            _engine.Start();
        }
        public void Halt()
        {
            _engine.Stop();
        }
    }
    class Engine
    {
        public void virtual Start() {
            Console.writeline("Engine started");    
        }
        public void virtual Stop() {
            Console.writeline("Engine stopped");
        }
    }
    class RevtronEngine: Engine
    {
        public void override Start()
        {
            Console.writeline("RevtronEngine started");
        }
        public void override Stop()
        {
            Console.writeline("RevtronEngine stopped");
        }
    }
    class VericoreEngine: Engine
    {
        public void override Start()
        {
            Console.writeline("VericoreEngine started");
        }
        public void override Stop()
        {
            Console.writeline("VericoreEngine stopped");
        }

    }
    class KrytoechEngine: Engine
    {
        public void override Start()
        {
            Console.writeline("KrytoechEngine started");
        }
        public void override Stop()
        {
            Console.writeline("KrytoechEngine stopped");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TataCar _nexon = new TataCar();
            _nexon.Ignite();

            TataCar _harrier = new TataCar(); //Kryotech engine

            TataCar _hexa = new TataCar();//vericore engine
        }
    }
}
