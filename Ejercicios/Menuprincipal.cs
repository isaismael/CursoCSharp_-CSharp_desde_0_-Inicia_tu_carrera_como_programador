using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoCSharp.Ejercicios;

namespace CursoCSharp.Ejercicios
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            EjUno();
        }
        private void EjUno()
        {
            panelVisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            EjCuatro();
        }
        private void EjCuatro()
        {
            panelVisor.Controls.Clear();
            Ejercicio4 ctl = new Ejercicio4();
            ctl.titulo = btnE2.Text;
            ctl.Dock= DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
