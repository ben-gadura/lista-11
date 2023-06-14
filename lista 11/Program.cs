using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lista_11
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] n;
            int numero = 0;
            n = new int[1000];
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                n[i] = rand.Next(1, 1000);
            }
            Console.WriteLine("chute um valor entre 0 e 1000");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1000; i++)
            {
                if (n[i] == numero)
                {
                    Console.WriteLine("você acertou o numero");
                    break;
                }
            }
        }

        public static void Exercicio2()
        {
            int cont = 0;
            int numero;
            int[] n;
            n = new int[20000];
            Random rand = new Random();
            for (int i = 0; i < 20000; i++)
            {
                n[i] = rand.Next(1, 20000);
            }
            Console.WriteLine("chute um valor entre 0 e 20000");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 20000; i++)
            {
                if (n[i] == numero)
                {
                    cont++;
                }
            }
            for (int i = 0; i < 20000; i++)
            {
                Console.WriteLine("o numero aparece " + cont + "vezes");
            }
        }

        public static void Exercicio3()
        {
            int[] vet;
            int[] vet2;
            int[] vet3;

            vet = new int[10]


        }

        public static void Exercicio4()
        {
            int[] n;
            n = new int[5000];
            Random rand = new Random();
            for (int i = 0; i < 5000; i++)
            {
                n[i] = rand.Next(1, 5000);
            }
            Console.WriteLine("digite um nmr qulaquer: ");
            for (int i = 0; i < 5000; i++)
            {
                if (n[i] % 2 != 0 && n[i] % 3 != 0 && n[i] % 5 != 0)
                {
                    Console.WriteLine("o numeros digitado é primo");
                    Console.WriteLine("numeros primos {0} ", n[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int opção;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("digite 1 para exercicio 1");
                Console.WriteLine("digite 2 para exercicio 2");
                Console.WriteLine("digite 3 para exercicio 3");
                Console.WriteLine("digite 4 para exercicio 4");

                opção = int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;


                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;
                }




            } while (opção != 0);
        }
    }
}
