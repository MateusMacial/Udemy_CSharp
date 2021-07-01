using System.Globalization;

namespace Praticando_Classes_06_Increase_Payment.Entities
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;
        public double SalarioLiquido()
        {
            return GrossSalary - Tax;
        }
        public void AumentarSalario(double porcentagem)
        {
            GrossSalary = GrossSalary + (GrossSalary * porcentagem / 100.0);
        }
        public override string ToString()
        {
            return Name
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
