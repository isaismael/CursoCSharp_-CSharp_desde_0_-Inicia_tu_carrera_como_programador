using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.Ejercicios
{
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        double c;
        double resultado;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            asignarDatos();
            Calcular();
        }
        //
        private void asignarDatos()
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

        }
        //
        private void Calcular()
        {
            resultado = ((c + 5) * (Math.Pow(b, 2) -3 * a * c) * Math.Pow(a, 2)) / (4 * a);
            lblresultado.Text = resultado.ToString();
        }
    }
}
