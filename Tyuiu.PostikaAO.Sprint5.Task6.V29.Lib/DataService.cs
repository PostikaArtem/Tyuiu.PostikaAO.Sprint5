using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PostikaAO.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            int ler = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                string[] andr = line.Split(' ');
                
                foreach(string art in andr)
                {
                    if (art.Length == 7) ler++;
                }
            }
            return ler;
        }
    }
}
