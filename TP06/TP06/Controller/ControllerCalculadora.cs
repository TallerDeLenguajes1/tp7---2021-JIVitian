using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP06.Model;

namespace TP06.Controller
{
    public class ControllerCalculadora
    {
        private ViewCalculadora ventana;
        private Calculadora calculadora;

        public ControllerCalculadora(ViewCalculadora ventana)
        {
            this.calculadora = new Calculadora();
            this.ventana = ventana;
        }

        public void Sumar(string txtPantalla)
        {
            leerPantalla(txtPantalla);
            ventana.Pantalla.Text = calculadora.Suma().ToString();
        }

        public void Restar(string txtPantalla)
        {
            leerPantalla(txtPantalla);
            ventana.Pantalla.Text = calculadora.Resta().ToString();
        }

        public void Multiplicar(string txtPantalla)
        {
            leerPantalla(txtPantalla);
            ventana.Pantalla.Text = calculadora.Multiplicacion().ToString();
        }

        public void Dividir(string txtPantalla)
        {
            leerPantalla(txtPantalla);
            if (calculadora.Numero2 != 0)
                ventana.Pantalla.Text = calculadora.Division().ToString();
            else
                ventana.Pantalla.Text = "NAN";
        }

        public void EscribirPantalla(string numero)
        {
            ventana.Pantalla.Text += numero;
        }

        public string[] leerPantalla(string txtPantalla)
        {
            Regex separador = new Regex(" ");

            return separador.Split(txtPantalla);
            //string[] numeros;
            //if (txtPantalla.Contains('+'))
            //{
            //    numeros = txtPantalla.Split('+');
            //    calculadora.Numero1 = float.Parse(numeros[0]);
            //    calculadora.Numero2 = float.Parse(numeros[1])
            //}
            //else if (txtPantalla.Contains('-'))
            //{ 
            //    numeros = txtPantalla.Split('-');
            //    calculadora.Numero1 = float.Parse(numeros[0]);
            //    calculadora.Numero2 = float.Parse(numeros[1]);
            //}
            //else if (txtPantalla.Contains('*'))
            //{
            //    numeros = txtPantalla.Split('*');
            //    calculadora.Numero1 = float.Parse(numeros[0]);
            //    calculadora.Numero2 = float.Parse(numeros[1]);
            //}
            //else if (txtPantalla.Contains('/'))
            //{
            //    numeros = txtPantalla.Split('/');
            //    calculadora.Numero1 = float.Parse(numeros[0]);
            //    calculadora.Numero2 = float.Parse(numeros[1]);
            //}
            //else
            //{
            //    calculadora.Numero1 = float.Parse(txtPantalla);
            //}
        }

        public void EscribirResultado()
        {
            var operaciones = new Dictionary<string, float>
            {
                ["+"] = calculadora.Suma(),
                ["-"] = calculadora.Resta(),
                ["*"] = calculadora.Multiplicacion(),
                ["/"] = calculadora.Division()
            };

            try
            {
                string[] partes = leerPantalla(ventana.Pantalla.Text);

                calculadora.Numero1 = float.Parse(partes[0]);
                calculadora.Numero2 = float.Parse(partes[2]);

                ventana.Pantalla.Text = operaciones[partes[1]].ToString();
            }
            catch (Exception e) //Por si no se pudiera dividir entre 0 por ejemplo
            {
                ventana.Pantalla.Text = "NAN";
            }
        }
    }
}
