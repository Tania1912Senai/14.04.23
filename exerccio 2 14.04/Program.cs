// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: use switch case e funções/métodos para otimizar o algorítimo.
//Usa float para alcool e gasolina

internal class Program
{
    private static void Main(string[] args)
    {

        const float precoAlcool = 4.90f;
        const float precoGasolina = 5.30f;
        // cliente tem que escolher a opção
        // char opção;
        // cliente escolhe com A ou G
        Console.WriteLine($"Informe o combustível de sua preferência(A) - Álcool (B) - Gasolina");
        char preferencia = char.Parse(Console.ReadLine());
        switch (preferencia)
        {
            case 'A':
                Console.WriteLine($"Informe a quantidade de litros:");
                float quantidadeAlcool = float.Parse(Console.ReadLine());
                float valorAbastecido = (quantidadeAlcool * precoAlcool);
                Console.WriteLine($"O valor a ser pago:{valorAbastecido}");
                break;
            case 'B':
                Console.WriteLine($"Informe a quantidade de litros:");
                float quantidadeGasolina = float.Parse(Console.ReadLine());
                valorAbastecido = (quantidadeGasolina * precoGasolina);
                Console.WriteLine($"O valor a ser pago:{valorAbastecido}");
                break;
            default:
                Console.WriteLine($"Operação inválida, não informada corretamente");
                break;
        }
    }
}

