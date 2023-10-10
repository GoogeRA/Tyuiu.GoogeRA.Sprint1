using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoogeRA.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {

            const double e = 2.71828;

            double res = (x + Math.Pow((e), x)) + ((Math.Sin(Math.Pow((x), 5)) + Math.Pow((x), 5)) / Math.Pow((3), x)) +  (Math.Pow((y), 5) / Math.Pow((5), y));

            res = (res) / 1000;

            return Math.Round(res, 3);

            
        }
    }
}
