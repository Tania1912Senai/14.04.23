// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escreva uma mensagem que diga se

// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).


    {
        Console.WriteLine($"Digite o ano atual");
        int anoAtual = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite seu ano de nascimento");
        int anoNascimento = int.Parse(Console.ReadLine());

        int idade = anoAtual - anoNascimento;

        if (idade >= 16)
        {
            Console.WriteLine($"Vota este ano");
        }
        else
        {
            Console.WriteLine($"Não voto");
        }
    }

