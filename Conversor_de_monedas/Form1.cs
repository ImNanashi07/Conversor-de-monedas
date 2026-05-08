namespace Conversor_de_monedas
{
    public partial class Form1 : Form
    {
        private bool nuevoCalc = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Calcular_click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls.OfType<Label>().ToList())
            {
                if (control.Tag?.ToString() == "conversiones")
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }
            foreach (Control control in this.Controls.OfType<TextBox>().ToList())
            {
                if (control.Tag?.ToString() == "conversiones")
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }                    
            }

            if (nuevoCalc) 
            {
                if (cb_Moneda.SelectedItem != null && IntupHelper.LeerEntero(txt_Monto.Text))
                {
                   
                    List<string> divisa = new List<string>()
                    {
                        "USD - Dolar estadounidense",
                        "MXN - Peso mexicano",
                        "CAD - Dolar canadiense",
                        "EUR - Euro",
                        "JPY - Yen japones"
                    };


                    divisa.Remove(cb_Moneda.SelectedItem.ToString());

                    Form2 newWindow = new Form2(divisa);
                    newWindow.monedasSeleccionadas += (seleccionadas) =>
                    {
                        foreach (var moneda in seleccionadas)
                        {
                            Label lbl = new Label();
                            lbl.Text = moneda;
                            lbl.Location = new Point(50, 100 + Controls.Count * 30);
                            lbl.Tag = "conversiones";

                            TextBox txt = new TextBox();
                            txt.Text = "Resultado";
                            txt.Location = new Point(200, 100 + Controls.Count * 30);
                            txt.Tag = "conversiones";

                            this.Controls.Add(lbl);
                            this.Controls.Add(txt);
                        }
                    };
                    newWindow.ShowDialog();
                }
            }

            if (string.IsNullOrWhiteSpace(txt_Monto.Text))
            {
                MessageBox.Show("Ingresa un monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal monto;
            if (!decimal.TryParse(txt_Monto.Text, out monto))
            {
                MessageBox.Show("Ingresa un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
        }
    }
}
