internal class Program
{
    private static bool encontrado;

    private static void Main(string[] args)
    {
    Vetores:
        //Exercicio 6
        // Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
        // lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
        // pessoa (para convertida uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
        // entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
        // Tentativa de Resolução

        string[] nomes = new string[10]
        
//boll encontrado = false;
for (var i = 0; i < nomes.Length; i++) ;
        {
            Console.WriteLine($"Digite o {i + 1}"," º nome: ");
        
            nomes[1] = Console.ReadLine();
        }

        Console.WriteLine($"Informe um nome a ser buscado:");
        string nomeBuscado = Console.ReadLine();
        
        //processamento
        foreach (string nome in nomes)
        {
            if (nome == nomeBuscado)

            {
                encontrado = true;
                break;
            }
        }

        //saida

        if (encontrado == true)
        {
            Console.WriteLine($"Achei!");
        }
        else
        {
            Console.WriteLine($"Nao Achei");
        }
    }
}
//Nivel Pleno
//string resultadoPesquisa = encontrado == true ? "Achei": "Nao Achei";
//Console.WriteLine(resultadoPesquisa)

//Nivel Senior
//Console.WriteLine (encontrado == true? "Achei:"Nao Achei");


