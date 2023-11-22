using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter chart type (line, bar, pie):");
        string chartType = Console.ReadLine();

        Console.WriteLine("Enter data for visualization:");
        string data = Console.ReadLine();

        
        GraphFactory graphFactory = new GraphFactory();
        IChart chart = graphFactory.CreateChart(chartType);

        
        chart.Draw();

        Console.ReadLine();
    }
}