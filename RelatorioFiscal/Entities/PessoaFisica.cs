using System.Globalization;

namespace RelatorioFiscal.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude)
            : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculaImposto()
        {
            if (RendaAnual < 20000.0)
            {
                return (RendaAnual * 0.15) - (GastoSaude * 0.5);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.5);
            }
        }

        public override string ToString()
        {
            return Nome + ":" + " $" + this.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
