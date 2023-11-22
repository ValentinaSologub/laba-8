using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GraphFactory
    {
        public IChart CreateChart(string chartType)
        {
            switch (chartType.ToLower())
            {
                case "line":
                    return new LineChart();
                case "bar":
                    return new BarChart();
                case "pie":
                    return new PieChart();
                default:
                    throw new ArgumentException("Invalid chart type");
            }
        }
    }
}
