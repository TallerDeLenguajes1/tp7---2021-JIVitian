using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP06.Controller;

namespace TP06
{
    public partial class ViewCalculadora : Form
    {
        ControllerCalculadora controller;

        public ViewCalculadora()
        {
            InitializeComponent();
            this.controller = new ControllerCalculadora(this);
        }

        private void btnNro_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            controller.EscribirPantalla(boton.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "";
        }
    }
}
