using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PostikaAO.Sprint5.Task3.V23.Lib
{
    public class DataService : ISprint5Task3V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double result = (1+Math.Pow(x,2))/Math.Pow(x,2);
            double result1 = Math.Round(result, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(result1));
            }
            return path;
        }
    }
}
