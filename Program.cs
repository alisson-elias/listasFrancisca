using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Filmes();
        //Alunos();
        //Frutas();
        //Cidades();
        //Produtos();
        //Tarefas();
        CadastroAlunos();
    }
    static void Filmes()
    {
        List<string> filmes = new List<string>();

        filmes.Add("Avatar");
        filmes.Add("Vingadores");
        filmes.Add("Matrix");
        filmes.Add("Interestelar");

        Console.WriteLine("Lista de filmes:");

        foreach (string item in filmes)
        {
            Console.WriteLine("- " + item);
        }

        Console.WriteLine("\nTotal de filmes: " + filmes.Count);
    }
    static void Alunos()
    {
        List<string> alunos = new List<string>();

        alunos.Add("Pedro");
        alunos.Add("Marcos");
        alunos.Add("Julia");
        alunos.Add("Ana");
        alunos.Add("Ana Maria");

        Console.WriteLine($"primeiro aluno: {alunos[0]} \nultimo aluno:{alunos[alunos.Count - 1]}");
    }
    static void Frutas()
    {
        List<string> frutas = new List<string>();

        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Uva");
        frutas.Add("Laranja");

        Console.WriteLine("Lista de frutas:");

        foreach (string item in frutas)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine();
        frutas[1] = "Morango";
        foreach (string item in frutas)
        {
            Console.WriteLine("- " + item);
        }
    }
    static void Cidades()
    {
        List<string> cidades = new List<string>();

        cidades.Add(" Rio de Janeiro");
        cidades.Add("São Paulo");
        cidades.Add("Salvador");
        cidades.Add("Curitiba");

        Console.WriteLine("Cidades");

        foreach (string item in cidades)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine();
        cidades.RemoveAt(2);
        foreach (string item in cidades)
        {
            Console.WriteLine("- " + item);
        }
    }
    static void Produtos()
    {
        List<string> produtos = new List<string>();

        while (produtos.Count < 5)
        {

            Console.WriteLine("Digite o produto:");
            string produt = Console.ReadLine().ToLower();
            produtos.Add(produt);
            Console.Clear();
        }

        Console.WriteLine();

        Console.WriteLine("=== PRODUTOS CADASTRADOS ===");

        foreach (string item in produtos)
        {
            Console.WriteLine("- " + item);
        }
    }
    static void Tarefas()
    {
        List<string> tarefas = new List<string>();

        while (tarefas.Count < 5)
        {

            Console.WriteLine("Digite a tarefa:");
            string taref = Console.ReadLine().ToLower();
            tarefas.Add(taref);
            Console.Clear();
        }

        Console.WriteLine();

        Console.WriteLine("=== SUAS TAREFAS ===");

        foreach (string item in tarefas)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine("\nTotal de tarefas: " + tarefas.Count);
        Console.WriteLine();
        Console.WriteLine("Qual tarefa deseja remover?");
        string tare = Console.ReadLine();
        tarefas.Remove(tare);
        Console.WriteLine("=== LISTA ATUALIZADA ===");
        foreach (string item in tarefas)
        {
            Console.WriteLine("- " + item);
        }
    }
    static void CadastroAlunos()
    {
        List<string> alunos = new List<string>();

        while (alunos.Count < 10)
        {

            Console.WriteLine("Digite o nome do aluno:");
            string taref = Console.ReadLine().ToLower();
            alunos.Add(taref);
            Console.Clear();
        }

        Console.WriteLine();

        Console.WriteLine("=== ALUNOS CADASTRADOS ===");

        foreach (string item in alunos)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine("\nTotal de alunos: " + alunos.Count);
        Console.WriteLine();

        Console.WriteLine("Digite o nome de um aluno que deseja alterar.");
        string tar = Console.ReadLine().ToLower();  


        if (alunos.Contains(tar))
        {
            Console.Write("Digite o novo nome: ");
            string novoNome = Console.ReadLine().ToLower();

            int indice = alunos.IndexOf(tar);
            alunos[indice] = novoNome;

            Console.WriteLine("Aluno atualizado.");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }

        Console.WriteLine();

        Console.WriteLine("Digite o nome do aluno que deseja remover.");
        string tare = Console.ReadLine().ToLower();

        if (alunos.Remove(tare))
        {
            Console.WriteLine("Aluno removido.");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
        Console.WriteLine("=== LISTA ATUALIZADA ===");
        foreach (string item in alunos)
        {
            Console.WriteLine("- " + item);
        }
    }
}