using System;
using System.IO;
using System.Collections.Generic;

namespace OrganizaListaIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\lista.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    List<String> list = new List<string>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    list.Sort();

                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Correu um Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
