using System;

class Program
{
    static void Main()
    {
        //recebe as informações do jogador
        Console.WriteLine("Digite a quantidade de mana:");
        double mana = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tipo de inimigo (normal, forte, boss):");
        string tipoInimigo = Console.ReadLine().ToLower();

        Console.WriteLine("Digite a distância do alvo (em metros):");
        double distancia = double.Parse(Console.ReadLine());

        //determina e exibe a habilidade sugerida
        string habilidade = DeterminarHabilidade(ref mana, tipoInimigo, distancia);
        Console.WriteLine($"Habilidade sugerida: {habilidade}");
    }

    static string DeterminarHabilidade(ref double mana, string tipoInimigo, double distancia)
    {
        const double manaNecessariaHabilidadePoderosa = 50;
        double manaNecessaria = manaNecessariaHabilidadePoderosa;

        //ajusta a mana necessária com base no tipo de inimigo
        if (tipoInimigo == "forte" || tipoInimigo == "boss")
        {
            manaNecessaria += 10;
        }

        //ajusta a mana necessária com base na distância
        if (distancia < 10)
        {
            manaNecessaria -= 5;
        }

        //verifica se o jogador tem mana suficiente para usar a habilidade poderosa
        if (mana > manaNecessaria)
        {
            return "Habilidade Poderosa";
        }
        else
        {
            return "Habilidade Normal";
        }
    }
}
