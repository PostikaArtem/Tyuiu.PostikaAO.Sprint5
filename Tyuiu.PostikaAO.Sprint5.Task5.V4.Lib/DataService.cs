using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PostikaAO.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line=reader.ReadLine()) !=null )
                {
                    double.TryParse(line, out double x);
                    if (x-Math.Floor(x)!=0)
                    {
                        double tyry = Math.Round(x, 3);
                        res *= tyry;
                        
                    }
                }
            }
            return Math.Round(res,3);
        }
    }
}
