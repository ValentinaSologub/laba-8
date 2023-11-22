using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BarChart : IChart
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a bar chart");
        }
    }
}
