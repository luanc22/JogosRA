using System;

namespace ZigueZague.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;
            
            while(fecharApp == false)
            {
                Console.Write("Digite a frase: ");
                string frase = Console.ReadLine();
                frase = frase.ToUpper();

                char[] fraseQuebrada = frase.Replace(" ", "").ToCharArray();

                Console.WriteLine();

                for (int i = 0; i < fraseQuebrada.Length; i++)
                {
                    Console.WriteLine(fraseQuebrada[i]);
                    i++;

                    if (i == fraseQuebrada.Length)
                    {
                        break;
                    }

                    Console.WriteLine(" " + fraseQuebrada[i]);
                }

                Console.WriteLine();

                Console.WriteLine("Continuar?");
                string continuarSair = Console.ReadLine();
                Console.Clear();

                if (continuarSair == "0")
                {
                    fecharApp = true;
                }
                

            }
            
        }
    }
}
