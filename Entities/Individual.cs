
namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualInCome < 20000.00)
            {
                return (AnualInCome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualInCome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
