using System;
using System.Collections.Generic;
using System.IO;

namespace StruttureDatiApp
{
    class Program
    {
        private const string file = @"FileTesto.txt";
        private const string file1 = @"FileTesto1.txt";
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            using (StreamReader file = new StreamReader("FileTesto.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lista.Add(double.Parse(line));
                }
            }
            using(StreamWriter file1 = new StreamWriter("FileTesto1.txt"))
            {
                for (int i = lista.Count - 1; i >= 0; i--)
                {
                    file1.WriteLine(lista[i]);
                }
                file1.Flush();
            }

        }
    }
}