using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //creamos una instancia de formulario
            Inicio form = new Inicio();
            //mostramos la instancia del formulario
            form.Show();
            //ocultamos el login
            this.Hide();
            //se le asigna el evento closing, cuando se cierra se una con el evento que creamos
            form.FormClosing += frm_clossing;
        }
        //funcion privada que recibe un objeto y escucha el evento de close
        private void frm_clossing(object senter, FormClosingEventArgs e)
        {
            //muestra el login oculto
            this.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
