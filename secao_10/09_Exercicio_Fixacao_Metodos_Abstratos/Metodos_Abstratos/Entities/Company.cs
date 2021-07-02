using Metodos_Abstratos.Entities;
namespace Metodos_Abstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double taxPay;

            if(NumberOfEmployees < 10)
            {
                taxPay = AnualIncome * 0.16;
            }
            else
            {
                taxPay = AnualIncome * 0.14;
            }

            return taxPay;
        }
    }
}
