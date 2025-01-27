﻿
namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualInCome { get; set; }

        protected TaxPayer(string name, double anualInCome)
        {
            Name = name;
            AnualInCome = anualInCome;
        }

        public abstract double Tax();

    }
}
