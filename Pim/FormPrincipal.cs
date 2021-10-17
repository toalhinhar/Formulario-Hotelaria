using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim
{
    public partial class FormPrincipal : Form
    {
        private Form formularioAtivo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirPainelBody(Form form, object botao)
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
            }
            formularioAtivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(form);
            this.panelBody.Tag = form;
            form.BringToFront();
            form.Show();
            lblTitle.Text = form.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirPainelBody(new Forms.Dashboard(), sender);
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            AbrirPainelBody(new Forms.FormQuartos(), sender);
        }

        private void btnHospedes_Click(object sender, EventArgs e)
        {
            AbrirPainelBody(new Forms.Hospedes(), sender);
        }
    }
}

