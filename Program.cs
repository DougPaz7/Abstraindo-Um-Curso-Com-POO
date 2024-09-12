using Abstraindo_Um_Curso_Com_POO.Models;

int opcao = 0;

Pessoa p1 = new Pessoa("Douglas", "Lino", 20);
Pessoa p2 = new Pessoa("Alycia", "Maia", 21);

Curso c = new Curso("Curso DIO");
c.Aluno = new List<Pessoa>();
c.Data = new List<DateTime>();

do
{
    Console.WriteLine(@"
1 - Adicionar Aluno(a)
2 - Remover Aluno(a)
3 - Listar alunos
4 - Quantidade de alunos matriculados
5 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        c.AdicionarAluno(p1);
    }
    else if (opcao == 2)
    {
        c.RemoverAluno(p1);
    }
    else if (opcao == 3)
    {
        c.ListarAlunos();
    }
    else
    {
        c.ObrterQuantidadeDeAlunoMatriculados();
    }
} while (opcao != 5);
