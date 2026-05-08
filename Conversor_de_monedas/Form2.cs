using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Conversor_de_monedas
{
    public partial class Form2 : Form
    {
        public event Action<List<string>> monedasSeleccionadas;

        public Form2(List<string> divisasDisponibles)
        {
            InitializeComponent();

            foreach (var item in divisasDisponibles)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void btn_Aceptar_click(Object sender, EventArgs e)
        {
            List<string> seleccionadas = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                seleccionadas.Add(item.ToString());
            }

            monedasSeleccionadas?.Invoke(seleccionadas);

            this.Close();
        }
    }
}
