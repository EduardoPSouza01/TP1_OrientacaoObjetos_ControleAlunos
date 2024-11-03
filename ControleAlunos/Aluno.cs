using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAlunos
{
    internal class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public double[] Notas { get; set; } = new double[4];

        public double CalcularMedia()
        {
            double[] pesos = { 1, 1, 1, 7 };
            double somaPonderada = 0;
            double somaPesos = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                somaPonderada += Notas[i] * pesos[i];
                somaPesos += pesos[i];
            }

            return somaPonderada / somaPesos;
        }
    }
}
