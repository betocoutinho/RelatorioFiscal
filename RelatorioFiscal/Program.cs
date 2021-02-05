using System;
using System.Collections.Generic;
using RelatorioFiscal.Entities;
using System.Globalization;

namespace RelatorioFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();
            Console.Write("Informe o Numero de Contribuintes: ");
            int cont = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cont; i++)
            {
                Console.WriteLine($"Dados do Contribuinte #{i}");

                Console.Write("Pessoa Fisica ou Pessoa Juridica (f/j): ");
                string tipo = Console.ReadLine();

                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Informe a Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tipo)
                {
                    case "f":
                       
                        Console.Write("Despesas Medicas: ");
                        double despesasMedicas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        lista.Add(new PessoaFisica(nome, rendaAnual, despesasMedicas));
                        
                        break;
                    case "j":
                        
                        Console.Write("InFome o Numero de Funcionarios: ");
                        double quantFuncionarios = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        lista.Add(new PessoaJuridica(nome, rendaAnual, quantFuncionarios));
                        break;

                    default:
                        break;
                }
            }

            double soma = 0;
            Console.WriteLine("Taxas Pagas:");

            foreach (Contribuinte item in lista)
            {
                Console.WriteLine(item.ToString()) ;
                soma += item.CalculaImposto();
            }

            Console.WriteLine("Total de Taxas: " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
