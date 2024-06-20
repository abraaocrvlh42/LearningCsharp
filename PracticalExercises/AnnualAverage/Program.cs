using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] faturamentoDiario = new double[]
        {
            // Exemplo de valores de faturamento
            100.0, 200.0, 0.0, 0.0, 150.0, 250.0, 300.0,
            // ... (valores para todos os dias do ano)
        };

        // Filtrar apenas os dias com faturamento
        var diasComFaturamento = faturamentoDiario.Where(valor => valor > 0).ToArray();

        // Calcular o menor valor de faturamento
        double menorFaturamento = diasComFaturamento.Min();

        // Calcular o maior valor de faturamento
        double maiorFaturamento = diasComFaturamento.Max();

        // Calcular a média anual de faturamento
        double mediaAnual = diasComFaturamento.Average();

        // Contar o número de dias com faturamento superior à média anual
        int diasAcimaDaMedia = diasComFaturamento.Count(valor => valor > mediaAnual);

        // Exibir os resultados
        Console.WriteLine("Menor valor de faturamento em um dia do ano: " + menorFaturamento);
        Console.WriteLine("Maior valor de faturamento em um dia do ano: " + maiorFaturamento);
        Console.WriteLine("Número de dias com faturamento superior à média anual: " + diasAcimaDaMedia);
    }
}
