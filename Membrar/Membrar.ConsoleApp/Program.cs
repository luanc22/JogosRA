using System;

namespace Membrar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;

            while (fecharApp == false)
            {
                string frase;

                Console.WriteLine("Digite a frase: ");
                Console.WriteLine("");
                frase = Console.ReadLine();

                Console.WriteLine("");

                char[] fraseQuebrada = frase.ToCharArray();
                int ultimoChar = fraseQuebrada.Length - 1;
                int cont = 0;
                int ultimoCharDesc = ultimoChar;
                int temp = 0;
                int cont1 = 0;

                for (int i = ultimoChar; i >= 0; i--)
                {
                    char charMaiusculo = fraseQuebrada[i];

                    Console.Write(char.ToUpper(charMaiusculo));
                    if (cont != 0)
                    {
                        if (charMaiusculo != ' ')
                        {
                            for (int j = 1; j <= cont; j++)
                            {
                                Console.Write(fraseQuebrada[ultimoCharDesc]);
                                if (cont1 == 0)
                                {
                                    temp = ultimoCharDesc;
                                }
                                ultimoCharDesc = ultimoCharDesc + 1;
                                cont1++;
                            }
                        }
                        else
                        {
                            ultimoCharDesc = ultimoCharDesc - 1;
                        }
                    }

                    if (i == ultimoCharDesc)
                    {
                        cont++;
                        cont1 = 0;
                        Console.WriteLine("");
                    }
                    else
                    {
                        ultimoCharDesc = temp - 1;
                        cont++;
                        cont1 = 0;
                        Console.WriteLine("");
                    }
                }

                Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Fechar?");
                string input = Console.ReadLine();

                if(input == "0")
                {
                    fecharApp = true;
                }

                Console.Clear();
            }
        }
    }
}
