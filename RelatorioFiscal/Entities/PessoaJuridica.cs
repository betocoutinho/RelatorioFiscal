using System.Globalization;

namespace RelatorioFiscal.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public double QuantFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, double quantFuncionarios)
            : base(nome, rendaAnual)
        {
            QuantFuncionarios = quantFuncionarios;
        }

        public override double CalculaImposto()
        {
            if (QuantFuncionarios > 10.0)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }

        public override string ToString()
        {
            return  Nome + ":" + " $" + this.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
