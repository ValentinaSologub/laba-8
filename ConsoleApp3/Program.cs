using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a product type (1 - Smartphone, 2 - Laptop):");
        int choice = int.Parse(Console.ReadLine());

        TechProductFactory factory = null;

        if (choice == 1)
        {
            factory = new SmartphoneFactory();
        }
        else if (choice == 2)
        {
            factory = new LaptopFactory();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        TechProductClient client = new TechProductClient(factory);
        client.AssembleProduct();

        Console.ReadLine();
    }
}
