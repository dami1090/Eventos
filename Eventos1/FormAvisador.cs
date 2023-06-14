using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GGGG;


namespace Eventos1
{
    public partial class FormAvisador : Form
    {
        private Usuario user = null;
        // me da error esto :S
        //private System.ComponentModel.IContainer components = null;
        //protected override void Dispose (bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        public FormAvisador()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (user is null)
            {
                user = new Usuario();
                user.EventoString += NotificarCambio;
                user.Apellido = txbApe.Text;
                user.Nombre = txbNombre.Text;
                btnUpdate.Text = "Actualizar";
            }else
            {
                user.Apellido = txbApe.Text;
                user.Nombre = txbNombre.Text;
            }

            lbl_NombreCompleto.Text = user.Mostrar();
        }

        public void NotificarCambio(string text)
        {
            MessageBox.Show($"Notificacion para: { text}", "Entrada", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
