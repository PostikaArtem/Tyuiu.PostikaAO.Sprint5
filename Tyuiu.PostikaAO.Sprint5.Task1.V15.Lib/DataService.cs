using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PostikaAO.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strX;
            for(int x = startValue; x<=stopValue; x++)
            {
                y = Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2;
                if(double.IsInfinity(y)|| double.IsNaN(y))
                {
                    y = 0;
                }
                y = Math.Round(y, 2);
                strX = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strX + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strX);
                }
            }
            return path;
        }
    }
}
