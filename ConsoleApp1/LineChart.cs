using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LineChart: IChart
    {
        public void Draw() 
        {
            Console.WriteLine("Drawing a line chart");
        }
    }
}
