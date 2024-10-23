using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSemLimitesLogica
{
    internal class Objeto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Peso { get; private set; }

        public Objeto(int id, string nome , double peso)
        {
            Id = id;
            Nome = nome;
            Peso= peso;
        }

    }
}
