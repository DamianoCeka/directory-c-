using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace progetto_creazione_cartelle
{
    internal class Program
    {
        static void Main(string[] args)


        {

            FindOrCreate(@"C:\Users\39327\Desktop\Clienti");
            //CreateFile(@"C:\Users\39327\Desktop\Clienti\File clienti.txt");
            WriteOnFile(@"C:\Users\39327\Desktop\Clienti", "File clienti.txt");





            static void FindOrCreate(String path)
            {
                DirectoryInfo info = new DirectoryInfo(path);

                if (info.Exists)
                {
                    Console.WriteLine(info.FullName);
                    Console.WriteLine(info.Name);
                    Console.WriteLine(info.Parent);
                }
                else
                {
                    info.Create();
                    Console.WriteLine(info.FullName);
                    Console.WriteLine(info.Name);
                    Console.WriteLine(info.Parent);
                }
            }
            //static void CreateFile(string FileName)
            //{
            //    File.Create(FileName);
            //}
            static void WriteOnFile(string path, string FileName)
            {
                List<string> mytext = new List<string>()  // volevo implementare Clienti ma non sono riucito 
                
            {
                "Damiano",
                "Bruno",
                "Michele"
            };

                File.AppendAllLines(Path.Combine(path, FileName), mytext);
            }

        }
    }
}
            
//            public class Cliente
//       {
//            public string _name;
//            public int _numeroConto;
//            public int _eta;

//        public Cliente(string name, int numeroConto, int eta)
//        {
//            _name = name;
//            _numeroConto = numeroConto;
//            _eta = eta;
//        }
//      }
//}

