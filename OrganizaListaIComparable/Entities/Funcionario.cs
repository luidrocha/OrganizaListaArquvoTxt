using System;
using System.Globalization;

namespace OrganizaListaIComparable.Entities
{
    class Funcionario : IComparable
    {
        private string Nome { get; set; }
        private double Salario { get; set; }



        public Funcionario(string funcionario)
        {
            string[] Vet = funcionario.Split(',');
            Nome = Vet[0];
            Salario = double.Parse(Vet[1]);

        }

        public override string ToString()
        {
            return "Nome: "
                    + Nome
                    + " Salario "
                    + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)

        {
            if (!(obj is Funcionario))
                throw new ArgumentException("Erro na comparação, objeto não é do tipo Funcionario");
            else
            {
                Funcionario Outro = obj as Funcionario; // Teve que fazer um DOWNCAST para Funcionario

                return Nome.CompareTo(Outro.Nome);
            }
        }
    }
}
