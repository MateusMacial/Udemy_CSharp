using Metodos_Abstratos.Entities;

namespace Metodos_Abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpeditures) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }
        public override double Tax()
        {
            double taxPay;

            if(AnualIncome < 20000.00)
            {
                taxPay = AnualIncome * 0.15;
            }
            else
            {
                taxPay = AnualIncome * 0.25;
            }

            return taxPay - (HealthExpeditures * 0.5);
        }
    }
}
