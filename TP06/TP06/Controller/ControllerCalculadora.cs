using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void EscribirNumero(string numero)
        {
            // Si hay un unico 0 en pantalla, no se podrán escribir mas 0
            if (ventana.Pantalla.Text != "0" || numero != "0")
                ventana.Pantalla.Text += numero;
            // Si hubo un NAN o alguna palabra, será reemplazada por un número
            if (new Regex(@"[a-zA-Z]+").IsMatch(ventana.Pantalla.Text))
                ventana.Pantalla.Text = numero;
        }

        public void Vaciar()
        {
            ventana.Pantalla.Clear();
        }

        public void EscribirPunto()
        {
            Regex controlPunto = new Regex(@"\d*\.\d*\z");
            // Controlo que no haya mas de un punto por termino
            if (!controlPunto.IsMatch(ventana.Pantalla.Text))
            {
                if (ventana.Pantalla.Text == "" || ventana.Pantalla.Text.EndsWith(" "))
                    ventana.Pantalla.Text += "0.";
                else
                    ventana.Pantalla.Text += ".";
            }
        }

        public void EscribirSigno(string signo)
        {
            Regex signos = new Regex(@"(\+|\-|\*|\/)\s\z");
            // Para poder ingresar numeros negativos al inicio
            if (ventana.Pantalla.Text == "" && signo == "-") 
                ventana.Pantalla.Text += signo;
            // Solo puedo ingresar un signo si hay un numero atras
            if (new Regex(@"\d+\z").IsMatch(ventana.Pantalla.Text)) 
                ventana.Pantalla.Text += $" {signo} ";
            if (signos.IsMatch(ventana.Pantalla.Text)) // Reemplazo el ultimo signo
                ventana.Pantalla.Text = signos.Replace(ventana.Pantalla.Text, $"{signo} ");
        }

        public void EscribirDesdeTeclado(char key)
        {
            string valor = key.ToString();
            Regex cNumero = new Regex(@"\d");
            Regex cSigno = new Regex(@"\+|\-|\*|\/");

            if (cNumero.IsMatch(valor)) EscribirNumero(valor);
            if (cSigno.IsMatch(valor)) EscribirSigno(valor);
            if (key == '.') EscribirPunto();
            if (key == '\r') EscribirResultado();
            if (key == 'c' || key == 'C') Vaciar();
        }

        public string[] leerPantalla()
        {
            Regex separador = new Regex(" ");
            return separador.Split(ventana.Pantalla.Text);
        }

        public void EscribirResultado()
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                string[] partes = leerPantalla();
                if (partes.Length == 3 && partes[2] != "")
                {
                    calculadora.Numero1 = float.Parse(partes[0], culture);
                    calculadora.Numero2 = float.Parse(partes[2], culture);

                    if (partes[1] == "+")
                        ventana.Pantalla.Text = calculadora.Suma().ToString(culture);
                    else if (partes[1] == "-")
                        ventana.Pantalla.Text = calculadora.Resta().ToString(culture);
                    else if (partes[1] == "*")
                        ventana.Pantalla.Text = calculadora.Multiplicacion().ToString(culture);
                    else if (partes[1] == "/")
                        ventana.Pantalla.Text = (calculadora.Numero2 != 0) ? calculadora.Division().ToString(culture) : "NAN";
                }
            }
            catch (Exception e) //Por si pasara algo raro
            {
                ventana.Pantalla.Text = "NAN";
            }
        }
    }
}
