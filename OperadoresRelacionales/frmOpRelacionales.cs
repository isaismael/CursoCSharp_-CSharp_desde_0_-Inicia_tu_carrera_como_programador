using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.OperadoresRelacionales
{
    public partial class frmOpRelacionales : Form
    {
        public frmOpRelacionales()
        {
            InitializeComponent();
        }
        //Variables
        int numero1;
        int numero2;
        bool resultado;

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }
        //funciones creadas
        private void Mayor()
        {
            asignacion();
            //
            if (numero1 > numero2) 
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }

        private void Menor()
        {
            asignacion();
            //
            if (numero1 < numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
        private void Mayorigual()
        {
            asignacion();
            //
            if (numero1 >= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
        private void Menorigual()
        {
            asignacion();
            //
            if (numero1 <= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
        private void Igual()
        {
            asignacion();
            //
            if (numero1 == numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
        private void Distinto()
        {
            asignacion();
            //
            if (numero1 != numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }

        private void asignacion()
        {
            numero1 = Convert.ToInt32(txtnum1.Text);
            numero2 = Convert.ToInt32(txtnum2.Text);
        }


        private void btnmayor_Click(object sender, EventArgs e)
        {
            Mayor();
        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            Menor();
        }

        private void btnmayoreigual_Click(object sender, EventArgs e)
        {
            Mayorigual();
        }

        private void btnmenoreigual_Click(object sender, EventArgs e)
        {
            Menorigual();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Igual();
        }

        private void btndistinto_Click(object sender, EventArgs e)
        {
            Distinto();
        }
    }
}
