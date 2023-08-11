using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaDojoAgreda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           if (txtboxUsuario.Text=="" || txtboxUsuario.Text!="turco")
            {
                MessageBox.Show("Ingrese el usuario y/o contraseña correcta");
               
                txtboxUsuario.Clear();
                txtboxContrasena.Clear();

            } else if (txtboxContrasena.Text=="" || txtboxContrasena.Text!="akbagreda") 
            {
                MessageBox.Show("Ingrese la contraseña y/o usuario correcto");
              

                txtboxUsuario.Clear();
                txtboxContrasena.Clear();

            } else if (txtboxUsuario.Text == "turco" && txtboxContrasena.Text == "akbagreda")
            {
                this.Hide();
                frmCobroMensual cobroMensual = new frmCobroMensual();
                cobroMensual.Show();
            }
        }
    }
}
