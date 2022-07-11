using System;

namespace Gaderipoluty.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFrasePalavra;


            bool fecharApp = false;
            while (fecharApp == false)
            {
                Console.Write("Digite a palavra/frase: ");
                inputFrasePalavra = Console.ReadLine();
                char[] FrasePalavraQuebrada = inputFrasePalavra.ToCharArray();


                for (int j = 0; j < FrasePalavraQuebrada.Length; j++)
                {
                    if (FrasePalavraQuebrada[j] == 'G')
                    {
                        FrasePalavraQuebrada[j] = 'A';
                    }
                    else if (FrasePalavraQuebrada[j] == 'A')
                    {
                        FrasePalavraQuebrada[j] = 'G';
                    }
                    else if (FrasePalavraQuebrada[j] == 'D')
                    {
                        FrasePalavraQuebrada[j] = 'E';
                    }
                    else if (FrasePalavraQuebrada[j] == 'E')
                    {
                        FrasePalavraQuebrada[j] = 'D';

                    }
                    else if (FrasePalavraQuebrada[j] == 'R')
                    {
                        FrasePalavraQuebrada[j] = 'I';
                    }
                    else if (FrasePalavraQuebrada[j] == 'I')
                    {
                        FrasePalavraQuebrada[j] = 'R';
                    }
                    else if (FrasePalavraQuebrada[j] == 'P')
                    {
                        FrasePalavraQuebrada[j] = 'O';
                    }
                    else if (FrasePalavraQuebrada[j] == 'O')
                    {
                        FrasePalavraQuebrada[j] = 'P';
                    }
                    else if (FrasePalavraQuebrada[j] == 'L')
                    {
                        FrasePalavraQuebrada[j] = 'U';
                    }
                    else if (FrasePalavraQuebrada[j] == 'U')
                    {
                        FrasePalavraQuebrada[j] = 'L';
                    }
                    else if (FrasePalavraQuebrada[j] == 'T')
                    {
                        FrasePalavraQuebrada[j] = 'Y';
                    }
                    else if (FrasePalavraQuebrada[j] == 'Y')
                    {
                        FrasePalavraQuebrada[j] = 'T';
                    }

                    if (FrasePalavraQuebrada[j] == 'g')
                    {
                        FrasePalavraQuebrada[j] = 'a';
                    }
                    else if (FrasePalavraQuebrada[j] == 'a')
                    {
                        FrasePalavraQuebrada[j] = 'g';
                    }
                    else if (FrasePalavraQuebrada[j] == 'd')
                    {
                        FrasePalavraQuebrada[j] = 'e';
                    }
                    else if (FrasePalavraQuebrada[j] == 'e')
                    {
                        FrasePalavraQuebrada[j] = 'd';

                    }
                    else if (FrasePalavraQuebrada[j] == 'r')
                    {
                        FrasePalavraQuebrada[j] = 'i';
                    }
                    else if (FrasePalavraQuebrada[j] == 'i')
                    {
                        FrasePalavraQuebrada[j] = 'r';
                    }
                    else if (FrasePalavraQuebrada[j] == 'p')
                    {
                        FrasePalavraQuebrada[j] = 'o';
                    }
                    else if (FrasePalavraQuebrada[j] == 'o')
                    {
                        FrasePalavraQuebrada[j] = 'p';
                    }
                    else if (FrasePalavraQuebrada[j] == 'l')
                    {
                        FrasePalavraQuebrada[j] = 'u';
                    }
                    else if (FrasePalavraQuebrada[j] == 'u')
                    {
                        FrasePalavraQuebrada[j] = 'l';
                    }
                    else if (FrasePalavraQuebrada[j] == 't')
                    {
                        FrasePalavraQuebrada[j] = 'y';
                    }
                    else if (FrasePalavraQuebrada[j] == 'y')
                    {
                        FrasePalavraQuebrada[j] = 't';
                    }
                }


                Console.WriteLine("");
                Console.WriteLine(inputFrasePalavra);
                Console.WriteLine("");

                for (int i = 0; i < FrasePalavraQuebrada.Length; i++)
                {
                    Console.Write(FrasePalavraQuebrada[i]);
                }

                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();            
            }
        }
    }
}
