using System;

namespace PontilhadoVirgulite.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharProg = false;

            while(fecharProg == false)
            {
                Console.Clear();
                Console.Write("Frase: ");
                string frase = Console.ReadLine();

                char[] fraseQuebrada = frase.ToCharArray();

                Console.WriteLine();
                Console.WriteLine("Pontilhado: ");
                Console.WriteLine();

                for (int i = 0; i < fraseQuebrada.Length; i++)
                {
                    if (fraseQuebrada[i] == ' ')
                    {
                        Console.Write(fraseQuebrada[i]);
                        continue;
                    }

                    Console.Write(fraseQuebrada[i]);
                    Console.Write(".");
                }

                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Virgulite: ");
                Console.WriteLine();

                for (int i = 0; i < fraseQuebrada.Length; i++)
                {
                    if (fraseQuebrada[i] == ' ')
                    {
                        Console.Write(fraseQuebrada[i]);
                        continue;
                    }

                    Console.Write(fraseQuebrada[i]);
                    Console.Write(",");
                }

                string sair = Console.ReadLine();

                if(sair == "0")
                {
                    fecharProg = true;
                }
            }
            
        }
    }
}
