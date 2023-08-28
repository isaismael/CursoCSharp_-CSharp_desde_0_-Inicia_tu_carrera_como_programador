using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.Condicionales
{
    public partial class FrmCondicionales : Form
    {
        public FrmCondicionales()
        {
            InitializeComponent();
        }
        int numero;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Asignar();
            Calcular();
        }
        private void Calcular()
        {
            if (numero > 0)
            {
                lblResultado.Text = "Es un numero Positivo!";
            }
            else if (numero == 0)
            {
                lblResultado.Text = "Es un valor 0";
            }
            else
            {
                lblResultado.Text = "Es un numero Negativo!";
            }
        }
        private void Asignar()
        {
            numero = Convert.ToInt32(txtnum.Text);
        }
    }
}
