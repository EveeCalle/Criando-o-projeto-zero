
namespace projeto1
{
    class doces
    {
       public string Confeiteiro { get; set; } 
       public double CapacidadeKg { get; set; }
       public double PorcentagemPronta { get; set; }
       public double TaxaProducaoHora { get; set; }


        public double CalcularKgFaltantes()

        {
            double porcentagemFaltante = (100.00 - porcetagemAtual) / 100.00;

            return CapacidadeKg * porcentagemFaltante;


        }
    }



}
