//Exercicio de Fixacao e Atividade
//
//1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se

//ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

//Console.WriteLine($"Digite o ano atual");
//int anoAtual = int.Parse(Console.ReadLine());

//Console.WriteLine($"Digite seu ano de nascimento");
//int anoNascimento = int.Parse(Console.ReadLine());

//int idade = (anoAtual) - (anoNascimento);

//if (idade >=16)
//{
//    Console.WriteLine($"Vota este ano");    
//}
//else
//{
//   Console.WriteLine($"Nao vota");    
//}
//Exercicio de fixacao

//2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
//Álcool:
//. até 20 litros, desconto de 3% por litro Álcool
//. acima de 20 litros, desconto de 5% por litro
//Gasolina:
//. até 20 litros, desconto de 4% por litro Gasolina
//. acima de 20 litros, desconto de 6% por litro

//Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
//da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
//sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
//Dica: utilize switch case e funções/métodos para otimizar o algorítimo.
//float para alccol e gasolina
//const float precoAlcool = 4,90f;
//const float precoGasolina = 5,30f;
//float quantidadeAlcool;
//float quantidadeGasolina;
//float valorAbastecido;
//cliente tem que escolher a opcao
//char opcao;
//cliente escolhe com A ou G
//Console.WriteLine
//(@$"Informe o combustivel de sua preferencia
//(A) - Alcool (B) - Gasolina");
//switch (opcao)
//    Case'A':
//       Console.WriteLine($"Informe quantidade de litros:");
//        quantidadeAlcool = float.Parse (Console.ReadLine());                  
//        valorAbastecido = Alcool(quantidadeAlcool,precoAlcool);
//        Console.WriteLine($"O valor a ser pago:{valorAbastecido}");
//        break;
//    Case'B':
//        Console.WriteLine($"Informe quantidade de litros:");
//        quantidadeGasolina = float.Parse (Console.ReadLine());
//        valorAbastecido = Gasolina(quantidadeGasolina,precoGasolina);
//        Console.WriteLine($"O valor a ser pago:{valorAbastecido}");
//        break;
//    default: 
//        Console.Writeline($"Operacao invalida, nao informou corretamente");
//        break;

//3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else 


// Estruturas de repetição:

// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.
//solicite 10 numeros, leia os numeros digitados e informe o maior e o menor numero digitado
//int = N1,N2,N3,N4,N5,N6,N7,N8,N9 e N10
//tem que buscar, a variavel maior e variavel menor
//Console.WriteLine($"Informe valor de N1");
//N1 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N2");
//N2 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N3");
//N3 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N4");
//N4 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N5");
//N5 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N6");
//N6 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N7");
//N7 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N8");
//N8 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N9");
//N9 = Int32.Parse(Console.RediLine());
//Console.WriteLine($"Informe valor de N10");
//N10 = Int32.Parse(Console.RediLine());
// usar if
//Para achar o N maior e N menor compara cada N um a um
//Exemplo
// if((N1>= N2) && (N1>=N3) && (N1>=N4) && (N1>=N5) && (N1>=N6) && (N1>= N7) && (N1>=N8) && (N1>=N9) && (N1>=N10))
//{ Maior = N1;
//Console.WriteLine($"O numero N1 maior: {0}", maior);
//Console.WriteLine();
//}
//else


// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
// Recebe as Variaveis
int formula, contador, numero;
Console.Write("Digite o Numero para Obter a Taboada : ");
numero = Int32.Parse(Console.ReadLine());
//para
for (contador = 1; contador <= 10; contador++)
{
    formula = numero * contador;
    Console.WriteLine(numero + " X " + contador + " = " + formula);

}


// Vetores:
// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
//Tentativa de Resolucao
// nomes: vetor [1..10] de caracter
// nome: caracter
// i: inteiro
// para i de 1 ate 10 
// Console.WriteLine($"Digite o ", i, "º nome")
// Console.ReadLine(nomes[i])
 
// Console.WriteLine("Agora, digte novamente um nome entre os dez.")
// Console.ReadLine(nome)

// se encontrou nome i = verdadeiro
// escreval("Achei")
// senao
//escreva("Eu não achei!")

// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.
