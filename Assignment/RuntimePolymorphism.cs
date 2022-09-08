namespace ConsoleApp16
{

    class TataCar
    {
        public void Ignite(Engine _engine)
        {
            _engine.Start();
        }
        public void Halt(Engine _engine)
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
            RevtronEngine _revtron = new RevtronEngine();
            _nexon.Ignite(_revtron);

            TataCar _harrier = new TataCar();
            KrytoechEngine _kryotech = new KrytoechEngine();
            _harrier.Ignite(_kryotech);

            TataCar _hexa = new TataCar();
            VericoreEngine _vericore = new VericoreEngine();
            _hexa.Ignite(_vericore);
        }
    }
