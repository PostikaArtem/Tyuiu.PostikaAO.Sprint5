﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PostikaAO.Sprint5.Task3.V23.Lib;
namespace Tyuiu.PostikaAO.Sprint5.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = $@"C:\Users\sralr\source\repos\Tyuiu.PostikaAO.Sprint5\Tyuiu.PostikaAO.Sprint5.Task3.V23\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
