using System;

class Program
{
    //função para calcular a quantidade de vida recuperada
    static int CalcularVidaRecuperada(string tipoPocao, int nivelPersonagem, int quantidadePocoes)
    {
        int vidaBase = 0;
        int pontosAdicionais = 0;

        //definir a base de vida de acordo com o tipo de poção
        switch (tipoPocao.ToLower())
        {
            case "pequena":
                vidaBase = 10;
                break;
            case "média":
                vidaBase = 20;
                break;
            case "grande":
                vidaBase = 30;
                break;
            default:
                throw new ArgumentException("Tipo de poção inválido.");
        }

        //calcular pontos adicionais com base no nível do personagem
        if (nivelPersonagem > 5)
        {
            pontosAdicionais = (nivelPersonagem - 5) * 5;
        }

        //calcular a vida recuperada total
        int vidaRecuperada = (vidaBase + pontosAdicionais) * quantidadePocoes;
        return vidaRecuperada;
    }

    static void Main()
    {
        //exemplo de uso da função com a Tabela de Teste fornecida

        //teste 1
        string tipoPocao1 = "Pequena";
        int nivelPersonagem1 = 6;
        int quantidadePocoes1 = 3;
        int vidaRecuperada1 = CalcularVidaRecuperada(tipoPocao1, nivelPersonagem1, quantidadePocoes1);
        Console.WriteLine($"Test 1: {vidaRecuperada1} pontos"); // Esperado: 45 pontos

        //teste 2
        string tipoPocao2 = "Média";
        int nivelPersonagem2 = 10;
        int quantidadePocoes2 = 2;
        int vidaRecuperada2 = CalcularVidaRecuperada(tipoPocao2, nivelPersonagem2, quantidadePocoes2);
        Console.WriteLine($"Test 2: {vidaRecuperada2} pontos"); // Esperado: 60 pontos

        //teste 3
        string tipoPocao3 = "Grande";
        int nivelPersonagem3 = 4;
        int quantidadePocoes3 = 1;
        int vidaRecuperada3 = CalcularVidaRecuperada(tipoPocao3, nivelPersonagem3, quantidadePocoes3);
        Console.WriteLine($"Test 3: {vidaRecuperada3} ponto"); // Esperado: 30 pontos
    }
}
