using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Screen
    {
        public abstract void Display();
    }

    abstract class Processor
    {
        public abstract void Process();
    }

    abstract class Camera
    {
        public abstract void Capture();
    }

   
    class SmartphoneScreen : Screen
    {
        public override void Display()
        {
            Console.WriteLine("Smartphone Screen is displaying.");
        }
    }

    class SmartphoneProcessor : Processor
    {
        public override void Process()
        {
            Console.WriteLine("Smartphone Processor is processing.");
        }
    }

    class SmartphoneCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Smartphone Camera is capturing.");
        }
    }

    class LaptopScreen : Screen
    {
        public override void Display()
        {
            Console.WriteLine("Laptop Screen is displaying.");
        }
    }

    class LaptopProcessor : Processor
    {
        public override void Process()
        {
            Console.WriteLine("Laptop Processor is processing.");
        }
    }

    class LaptopCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Laptop Camera is capturing.");
        }
    }

    
    abstract class TechProductFactory
    {
        public abstract Screen CreateScreen();
        public abstract Processor CreateProcessor();
        public abstract Camera CreateCamera();
    }

   
    class SmartphoneFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new SmartphoneScreen();
        }

        public override Processor CreateProcessor()
        {
            return new SmartphoneProcessor();
        }

        public override Camera CreateCamera()
        {
            return new SmartphoneCamera();
        }
    }

    class LaptopFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new LaptopScreen();
        }

        public override Processor CreateProcessor()
        {
            return new LaptopProcessor();
        }

        public override Camera CreateCamera()
        {
            return new LaptopCamera();
        }
    }

    
    class TechProductClient
    {
        private TechProductFactory _factory;

        public TechProductClient(TechProductFactory factory)
        {
            _factory = factory;
        }

        public void AssembleProduct()
        {
            Screen screen = _factory.CreateScreen();
            Processor processor = _factory.CreateProcessor();
            Camera camera = _factory.CreateCamera();

            Console.WriteLine("Assembling product:");
            screen.Display();
            processor.Process();
            camera.Capture();
        }
    }

}
