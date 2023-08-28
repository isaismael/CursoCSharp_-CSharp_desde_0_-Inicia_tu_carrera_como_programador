using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.OperadoresLógicos
{
    public partial class frmOpLogicos : Form
    {
        public frmOpLogicos()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        bool resultado;

        private void frmOpLogicos_Load(object sender, EventArgs e)
        {

        }
        private void Asignar()
        {
            numero1 = Convert.ToInt32(txtnum1.Text);
            numero2 = Convert.ToInt32(txtnum2.Text);
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            OperadorY();
        }
        private void OperadorY()
        {
            Asignar();
            if (numero1 > 5 && numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresultado.Text = resultado.ToString();
        }
    }
}
