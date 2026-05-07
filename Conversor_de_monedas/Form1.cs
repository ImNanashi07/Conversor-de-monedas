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
            if (nuevoCalc) 
            {
                if (cb_Moneda.SelectedItem != null && IntupHelper.LeerEntero(txt_Monto.Text))
                {
                    Form2 newWindow= new Form2();
                    List<string> divisa = new List<string>();
                    divisa.Add("USD - Dolar estadounidense");
                }
            }
        }
    }
}
