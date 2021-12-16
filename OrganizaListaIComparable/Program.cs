using System;
using System.IO;
using System.Collections.Generic;
using OrganizaListaIComparable.Entities;

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

                    List<Funcionario> list = new List<Funcionario>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Funcionario func in list)
                    {
                        Console.WriteLine(func);
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
