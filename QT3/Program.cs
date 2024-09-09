using System;

class Program
{
    static void Main()
    {
        //recebe as informações do jogador
        Console.WriteLine("Digite o valor do ataque base:");
        double ataqueBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o multiplicador crítico (1.5, 2, 3):");
        double multiplicadorCritico = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tipo de arma (espada, arco, cajado):");
        string tipoArma = Console.ReadLine().ToLower();

        //calcula e exibe o dano crítico
        double danoCritico = CalcularDanoCritico(ataqueBase, multiplicadorCritico, tipoArma);
        Console.WriteLine($"O dano total causado pelo ataque crítico é: {danoCritico}");
    }

    static double CalcularDanoCritico(double ataqueBase, double multiplicadorCritico, string tipoArma)
    {
        //calcula o dano crítico inicial
        double danoCritico = ataqueBase * multiplicadorCritico;

        //aplica bônus adicional com base no tipo de arma
        switch (tipoArma)
        {
            case "espada":
                danoCritico += 10; //bônus de 10 pontos para espada
                break;

            case "arco":
                danoCritico += 5; //bônus de 5 pontos para arco
                break;

            case "cajado":
                danoCritico += 15; //bônus de 15 pontos para cajado
                break;

            default:
                Console.WriteLine("Tipo de arma inválido. Nenhum bônus aplicado.");
                break;
        }

        return danoCritico;
    }
}
