﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.vista
{
    public partial class FormReservacion : Form
    {
        public FormReservacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Reservacion formAsi = new Reservacion();

            formAsi.Fecha = "01/12/2018";
            formAsi.NumeroTarjeta = "265986";

            textFe.Text = formAsi.Fecha;
            textTar.Text = formAsi.NumeroTarjeta;
        }
    }
}
