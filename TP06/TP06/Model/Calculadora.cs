using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06.Model
{
    class Calculadora
    {
        private float numero1;
        private float numero2;
        private string operador;
        private float resultado;
        private DateTime fechaYHora;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string Operador { get => operador; set => operador = value; }
        public float Resultado { get => resultado; set => resultado = value; }
        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora = value; }

        public float Suma()
        {
            return Numero1 + Numero2;
        }

        public float Resta()
        {
            return Numero1 - Numero2;
        }

        public float Multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public float Division()
        {
            return Numero1 / Numero2;
        }

        public override string ToString()
        {
            return $"{fechaYHora} ---> {Numero1+Operador+Numero2}={Resultado}";
        }
    }
}
