using Abstraindo_Um_Curso_Com_POO.Models;

int opcao = 0;
int matricula = 1000;

Curso c = new Curso("Curso DIO");
c.Aluno = new List<Aluno>();
c.Data = new List<DateTime>();
c.Matricula = new List<int>();

do
{
    Console.WriteLine(@"
=======================================
|             Curso DIO               |
=======================================    
|1 - Adicionar Aluno(a)               |
|2 - Remover Aluno(a)                 |
|3 - Listar alunos                    |
|4 - Quantidade de alunos matriculados|
|5 - Sair                             |
=======================================");                          
    opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        c.AdicionarAluno(matricula);
        matricula += 1;
    }
    else if (opcao == 2)
    {
        c.RemoverAluno(matricula);
        matricula -= 1;
    }
    else if (opcao == 3)
    {
        c.ListarAlunos();
    }
    else if (opcao == 4)
    {
        c.ObrterQuantidadeDeAlunoMatriculados();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Obrigado por escolher o nosso curso!");
        break;
    }
} while (opcao != 5);
