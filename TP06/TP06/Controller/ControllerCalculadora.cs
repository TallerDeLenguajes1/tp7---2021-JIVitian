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
        // Ventana es la vista de la Calculadora
        private ViewCalculadora ventana;
        // Lista que contendrá la información del historial
        private LinkedList<Calculadora> lista;
        // culture indica que notación tendran los decimales de la calculadora.
        private CultureInfo culture;

        public ControllerCalculadora(ViewCalculadora ventana)
        {
            this.ventana = ventana;
            lista = new LinkedList<Calculadora>();
            culture = new CultureInfo("en-US");
        }

        public void EscribirNumero(string numero)
        {
            // Si hubo un NAN o alguna palabra, será reemplazada por un número
            if (new Regex(@"\A[a-zA-Z]+\z").IsMatch(ventana.Pantalla.Text))
                Vaciar();
            ventana.Pantalla.Text += numero;
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
            Regex signoAtras = new Regex(@"(\+|\-|\*|\/)\s\z");
            Regex controlSigno = new Regex(@"((\+|\-|\*|\/)\s\d+\z)");
            Regex numero = new Regex(@"\d+\z");

            // Si ya se usó un operador antes, no deja poner otro
            // puesto que la calculadora funciona solo con dos terminos
            if (!controlSigno.IsMatch(ventana.Pantalla.Text))
            {
                // Para poder ingresar numeros negativos al inicio
                if (ventana.Pantalla.Text == "" && signo == "-")
                    ventana.Pantalla.Text += signo;
                // Solo puedo ingresar un signo si hay un numero atras
                if (numero.IsMatch(ventana.Pantalla.Text))
                    ventana.Pantalla.Text += $" {signo} ";
                // Si hay un signo atras del que estoy por ingresar, lo reemplazo
                if (signoAtras.IsMatch(ventana.Pantalla.Text))
                    ventana.Pantalla.Text = signoAtras.Replace(ventana.Pantalla.Text, $"{signo} ");
            }
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

        private string[] leerPantalla()
        {
            Regex separador = new Regex(" ");
            return separador.Split(ventana.Pantalla.Text);
        }

        private void Calcular(Calculadora calculadora)
        {
            switch(calculadora.Operador)
            {
                case "+":
                    calculadora.Resultado = calculadora.Suma();
                    break;
                case "-":
                    calculadora.Resultado = calculadora.Resta();
                    break;
                case "*":
                    calculadora.Resultado = calculadora.Multiplicacion();
                    break;
                case "/":
                // Si intentamos dividir entre 0, se lanzará una excepcion y aparecera NAN en la pantalla
                    if (calculadora.Numero2 != 0)
                        calculadora.Resultado = calculadora.Division();
                    else
                        throw new Exception();
                    break;
            }
        }

        private Calculadora InicializarCalculadora(string[] partes)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Numero1 = float.Parse(partes[0], culture);
            calculadora.Operador = partes[1];
            calculadora.Numero2 = float.Parse(partes[2], culture);
            calculadora.FechaYHora = DateTime.Now;

            return calculadora;
        }

        private void ActualizarHistorial()
        {
            // Añado como primer item el primer elemento de la lista de calculadoras
            ventana.Historial.Items.Insert(0, lista.First.Value.ToString());
        }

        private void AgregarNodo(Calculadora calculadora)
        {
            // Añado el nuevo nodo al inicio de la lista.
            lista.AddFirst(new LinkedListNode<Calculadora>(calculadora));
        }

        public void EscribirResultado()
        {
            try
            {
                string[] partes = leerPantalla();

                if (partes.Length == 3 && partes[2] != "")
                {
                    Calculadora calculadora = InicializarCalculadora(partes);
                    Calcular(calculadora);
                    // Escribo el resultado en pantalla
                    ventana.Pantalla.Text = calculadora.Resultado.ToString(culture);
                    AgregarNodo(calculadora);
                    ActualizarHistorial();
                }
            }
            catch (Exception e) //Por si pasara algo raro
            {
                ventana.Pantalla.Text = "NAN";
            }
        }

        public void EliminarHistorial()
        {
            int indice = ventana.Historial.SelectedIndex;
            LinkedListNode<Calculadora> nodo = lista.First;

            // Si hacemos doble click sobre la listbox y no hay elemento seleccionado, el método SelectedIndex devuelve -1
            if (indice != -1)
            {
                ventana.Historial.Items.RemoveAt(indice);
                // Como la lista y el listbox tienen los mismos elementos y ordenados de la misma manera
                // avanzo tantos nodos como sea el valor del indice seleccionado por el usuario y lo saco de la lista
                for (int i = 0; i < indice; i++)
                    nodo = nodo.Next;
                lista.Remove(nodo);
            }
        }
    }
}
