using System;

class Program
{
    static void Main()
    {
        //recebe as informações do jogador
        Console.WriteLine("Digite a dificuldade da missão (fácil, média, difícil): ");
        string dificuldade = Console.ReadLine().ToLower();

        Console.WriteLine("Digite o número de inimigos derrotados: ");
        int inimigosDerrotados = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tempo gasto (em minutos): ");
        int tempoGasto = int.Parse(Console.ReadLine());

        //calcula e exibe a pontuação
        int pontuacao = CalcularPontuacao(dificuldade, inimigosDerrotados, tempoGasto);
        Console.WriteLine($"A pontuação final do jogador é: {pontuacao}");
    }

    static int CalcularPontuacao(string dificuldade, int inimigos, int tempo)
    {
        int pontuacao = 0;

        switch (dificuldade)
        {
            case "fácil":
                pontuacao = inimigos * 5;
                break;

            case "média":
                pontuacao = inimigos * 10;
                if (tempo > 10)
                {
                    pontuacao -= (tempo - 10) * 2;
                }
                break;

            case "difícil":
                pontuacao = inimigos * 15;
                if (tempo > 15)
                {
                    pontuacao -= (tempo - 15) * 5;
                }
                break;

            default:
                Console.WriteLine("Dificuldade inválida.");
                break;
        }

        //garante que a pontuação não seja negativa
        return Math.Max(pontuacao, 0);
    }
}
