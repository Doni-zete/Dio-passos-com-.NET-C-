using System;

namespace _04REVISÃO
{
    class Program
    {
        static void Main(string[] args)
        {


            Aluno[] alunos =new Aluno[5];
            var indiceAluno =0;
            string opcapUsuario = ObterOpcaoUsuario();

            while (opcapUsuario.ToUpper() != "X")
            {
                switch (opcapUsuario)
                {
                    case "1":
                        Console.WriteLine("informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("informe a nota do aluno:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))

                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor  de nota do aluno:");
                        }
                        
                        alunos[indiceAluno] =aluno;
                        indiceAluno++;
                      
                        break;


                    case "2":
                        foreach (var a in alunos)
                        {   if(!string.IsNullOrEmpty(a.Nome))

                        {
                            Console.WriteLine($"ALUNO: {a.Nome} -NOTA:{a.Nota}");
                        }
                        }                        
                            
                        
                        break;
                    case "3":
                    decimal notaTotal =0;
                    var nrAlunos = 0;
                        for (int i =0; i<alunos.Length; i++ )
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                            notaTotal = notaTotal +alunos[i].Nota;
                            nrAlunos++;
                        }
                        }
                        var mediaGeral = notaTotal/ nrAlunos;
                       if (mediaGeral <3)
                       {

                       }




                        Console.WriteLine($"Media Geral:{mediaGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcapUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
             Console.WriteLine();
             Console.WriteLine();
            Console.WriteLine("Informe a oção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcapUsuario = Console.ReadLine();
            Console.WriteLine();

            return opcapUsuario;
        }
    }
}
