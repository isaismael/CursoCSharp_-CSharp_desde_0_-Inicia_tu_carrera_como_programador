using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.OperadoresAritmeticos
{
    public partial class frmOpAritmeticos : Form
    {
        public frmOpAritmeticos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        double numero1;
        double numero2;
        double resultado;

        private void frmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Suma();
        }
        private void Suma()
        {
            try
            {
                txtnum1.Text = txtnum1.Text.Replace(".", ",");
                txtnum2.Text = txtnum2.Text.Replace(".", ",");
                numero1 = Convert.ToDouble(txtnum1.Text);
                numero2 = Convert.ToDouble(txtnum2.Text);
                resultado = numero1 + numero2;
                lblresultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Resta();
        }
        private void Resta()
        {
            numero1 = Convert.ToDouble(txtnum1.Text);
            numero2 = Convert.ToDouble(txtnum2.Text);
            resultado = numero1 - numero2;
            lblresultado.Text = resultado.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }
        private void Multiplicar()
        {
            numero1 = Convert.ToDouble(txtnum1.Text);
            numero2 = Convert.ToDouble(txtnum2.Text);
            resultado = numero1 * numero2;
            lblresultado.Text = resultado.ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            Dividir();
        }
        private void Dividir()
        {
            numero1 = Convert.ToDouble(txtnum1.Text);
            numero2 = Convert.ToDouble(txtnum2.Text);
            resultado = numero1 / numero2;
            lblresultado.Text = resultado.ToString();
        }

    }
}
