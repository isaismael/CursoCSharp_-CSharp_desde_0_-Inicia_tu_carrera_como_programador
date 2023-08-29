using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.Listas
{
    public partial class Frmlistas_arrays : Form
    {
        public Frmlistas_arrays()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //AgregarListas();
            AgregarArray();
        }
        private void AgregarListas()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Ismael");
            nombres.Add("Walter");
            nombres.Add("José");
            nombres.Add("24");
            //
            //for (int i = 0; i < nombres.Count; i++)
            //{
            //    lista_datos.Items.Add(nombres[i]);
            //}
            foreach (string data in nombres)
            {
                //en este metodo 'data' sera nuestro iterado, nuestro 'i' como en el bucle for
                lista_datos.Items.Add(data);
            }
        }
        private void AgregarArray()
        {
            //Este modo es si queremos especificar la cantidad de elementos en nuestro array
            //string[] nombres = new string[4] {"Amarillo", "Rojo", "Azul", "Naranja"};
            //
            string[] nombres = { "Amarillo", "Rojo", "Azul", "Naranja" };
            //Recorremos
            foreach (string data in nombres) 
            {
                lista_datos.Items.Add(data);
            }
        }

        private void Frmlistas_arrays_Load(object sender, EventArgs e)
        {
            DibujarNum();
        }
        private void DibujarNum()
        {
            char[] numeros;
            numeros = "0123456789".ToCharArray();
            panel_numerico.Controls.Clear();
            foreach (char numero in numeros)
            {
                Button btn_num = new Button();
                btn_num.Text = numero.ToString();
                btn_num.Size = new Size(74, 67);
                panel_numerico.Controls.Add(btn_num);
                //los controladores de eventos se agregan despues de que 
                //agregamos el btn por codigo
                btn_num.Click += Btn_num_Click;
            }
        }

        private void Btn_num_Click(object sender, EventArgs e)
        {
            string numero = ((Button )sender).Text;
            txt_pantalla.Text += numero;
        }
    }
}
