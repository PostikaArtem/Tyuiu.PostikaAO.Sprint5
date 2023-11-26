using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PostikaAO.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string spi = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V23.txt";

            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            FileInfo fileInfo = new FileInfo(spi);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(spi);

            string modLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    
                    foreach(char z in line)
                    {
                        if (!rus.Contains(Char.ToLower(z))) modLine += z;
                    }
                    File.AppendAllText(spi, modLine + Environment.NewLine);
                    modLine = "";
                }
            }
            return spi;
        }
    }
}
