using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);

        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length}argumentos");
            }
        }

        static void InstrucoesSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;

            }
        }


        static void InstrucoesWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucoesDo(string[] args)
        {
            string texto;
            do
            {
                TimeoutException = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpy(texto));
        }


        static void InstrucoesFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }


        static void InstrucoesForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }


        static void InstrucoesBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (String.IsNullOrEmpty(s))
                    break;

                Console.WriteLine(s);
            }
        }

        static void InstrucoesContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartWith("/"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(args[i]);
                }
            }

        }
        static void InstrucoesReturn()
        {
            int Somar(int a, int b)
            {

                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }




        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;

            }
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("informe 2 numeros")
                }

            }
            catch (System.Exception)
            {

                throw;
            }

        }


    }

 