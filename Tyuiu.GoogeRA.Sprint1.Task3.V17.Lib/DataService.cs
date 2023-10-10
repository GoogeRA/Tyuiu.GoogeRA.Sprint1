using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoogeRA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            
            string rest = number.ToString().Substring(number.ToString().IndexOf(',') + 1, 3);
            if (rest.Contains('0'))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
