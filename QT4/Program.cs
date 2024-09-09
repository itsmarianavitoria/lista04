using System;

class Program
{
    static void Main()
    {
        //recebe as informações do jogador
        Console.WriteLine("Digite a energia do jogador:");
        double energia = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a distância até o aliado (em metros):");
        double distancia = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nível de ameaça (baixo, médio, alto):");
        string nivelAmeaça = Console.ReadLine().ToLower();

        //verifica se o resgate é possível e exibe o resultado
        bool resgatePossivel = VerificarResgate(ref energia, distancia, nivelAmeaça);
        if (resgatePossivel)
        {
            Console.WriteLine("Resgate bem-sucedido!");
        }
        else
        {
            Console.WriteLine("Resgate falhou.");
        }
    }

    static bool VerificarResgate(ref double energia, double distancia, string nivelAmeaça)
    {
        //aplica bônus de energia baseado na distância
        if (distancia < 20)
        {
            energia += 10;
        }

        //aplica penalidades baseadas no nível de ameaça
        switch (nivelAmeaça)
        {
            case "baixo":
                //nenhuma penalidade
                break;

            case "médio":
                energia -= 10;
                break;

            case "alto":
                energia -= 20;
                break;

            default:
                Console.WriteLine("Nível de ameaça inválido.");
                return false;
        }

        //verifica se a energia é suficiente para um resgate bem-sucedido
        return energia > 50;
    }
}
