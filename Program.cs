using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoCSharp.Condicionales;
using CursoCSharp.Ejercicios;
using CursoCSharp.OperadoresAritmeticos;
using CursoCSharp.OperadoresLógicos;
using CursoCSharp.OperadoresRelacionales;

namespace CursoCSharp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menuprincipal());
        }
    }
}
