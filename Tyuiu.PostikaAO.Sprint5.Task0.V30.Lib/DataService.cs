using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PostikaAO.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double result3 = (Math.Pow(x,2) + 1) / (3 * x + 4);
            
            File.WriteAllText(path, result3.ToString());
            return path;
        }
    }
}
