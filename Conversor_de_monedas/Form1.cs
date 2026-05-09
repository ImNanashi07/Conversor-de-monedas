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
                        int yBase = 150;
                        int separacion = 40;
                        int i = 0;

                        decimal monto = decimal.Parse(txt_Monto.Text);

                        foreach (var moneda in seleccionadas)
                        {
                            Label lbl = new Label();
                            lbl.Text = moneda;
                            lbl.Location = new Point(30, yBase + i * separacion);
                            lbl.Tag = "conversiones";

                            decimal valorConvertido = Convertir(cb_Moneda.SelectedItem.ToString(), moneda, monto);

                            string simbolo = "";
                            if (moneda.StartsWith("USD")) simbolo = "$ ";
                            else if (moneda.StartsWith("MXN")) simbolo = "$ ";
                            else if (moneda.StartsWith("CAD")) simbolo = "$ ";
                            else if (moneda.StartsWith("EUR")) simbolo = "€ ";
                            else if (moneda.StartsWith("JPY")) simbolo = "¥ ";

                            TextBox txt = new TextBox();
                            txt.Text = simbolo + valorConvertido.ToString("00.00");
                            txt.Location = new Point(270, yBase + i * separacion);
                            txt.Tag = "conversiones";

                            this.Controls.Add(lbl);
                            this.Controls.Add(txt);

                            pictureBox1.SendToBack();

                            i++;
                        }
                    };
                    newWindow.ShowDialog();
                }
            }

            // éstas funciones las investigue en internet profe, son mensajes de error para cuando se ingresa un monto vacio o invalido
            // quice darle algo de originalidad para que muestre un mensaje en vez de no hacer nada.
            if (string.IsNullOrWhiteSpace(txt_Monto.Text))
            {
                MessageBox.Show("Ingresa un monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal monto;
            if (!decimal.TryParse(txt_Monto.Text, out monto))
            {
                MessageBox.Show("Ingresa un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private decimal Convertir(string origen, string destino, decimal monto)
        {
            decimal tasa = 0;

            switch (origen)
            {
                case "USD - Dolar estadounidense":
                    switch (destino)
                    {
                        case "MXN - Peso mexicano": tasa = 17.38m; break;
                        case "CAD - Dolar canadiense": tasa = 1.36m; break;
                        case "EUR - Euro": tasa = 0.86m; break;
                        case "JPY - Yen japones": tasa = 157.92m; break;
                    }
                    break;

                case "MXN - Peso mexicano":
                    switch (destino)
                    {
                        case "USD - Dolar estadounidense": tasa = 0.06m; break;
                        case "CAD - Dolar canadiense": tasa = 0.08m; break;
                        case "EUR - Euro": tasa = 0.05m; break;
                        case "JPY - Yen japones": tasa = 9.09m; break;
                    }
                    break;

                case "CAD - Dolar canadiense":
                    switch (destino)
                    {
                        case "USD - Dolar estadounidense": tasa = 0.73m; break;
                        case "MXN - Peso mexicano": tasa = 12.76m; break;
                        case "EUR - Euro": tasa = 0.63m; break;
                        case "JPY - Yen japones": tasa = 115.88m; break;
                    }
                    break;

                case "EUR - Euro":
                    switch (destino)
                    {
                        case "USD - Dolar estadounidense": tasa = 1.17m; break;
                        case "MXN - Peso mexicano": tasa = 20.32m; break;
                        case "CAD - Dolar canadiense": tasa = 1.59m; break;
                        case "JPY - Yen japones": tasa = 184.66m; break;
                    }
                    break;

                case "JPY - Yen japones":
                    switch (destino)
                    {
                        case "USD - Dolar estadounidense": tasa = 0.0063m; break;
                        case "MXN - Peso mexicano": tasa = 0.1101m; break;
                        case "CAD - Dolar canadiense": tasa = 0.0086m; break;
                        case "EUR - Euro": tasa = 0.0054m; break;
                    }
                    break;
            }

            return monto * tasa;
        }


        private void lbl_conversiones_Click(object sender, EventArgs e)
        {
            // Le di doble click por error profe :(, queria poner el label encima del pictureBox y se me fue
        }
    }
}
