namespace Conversor_de_monedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_moneda = new Label();
            lbl_monto = new Label();
            cb_Moneda = new ComboBox();
            txt_Monto = new TextBox();
            btn_Calcular = new Button();
            pictureBox1 = new PictureBox();
            lbl_conversiones = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_moneda
            // 
            lbl_moneda.AutoSize = true;
            lbl_moneda.Location = new Point(23, 15);
            lbl_moneda.Name = "lbl_moneda";
            lbl_moneda.Size = new Size(64, 20);
            lbl_moneda.TabIndex = 0;
            lbl_moneda.Text = "Moneda";
            // 
            // lbl_monto
            // 
            lbl_monto.AutoSize = true;
            lbl_monto.Location = new Point(267, 15);
            lbl_monto.Name = "lbl_monto";
            lbl_monto.Size = new Size(53, 20);
            lbl_monto.TabIndex = 0;
            lbl_monto.Text = "Monto";
            // 
            // cb_Moneda
            // 
            cb_Moneda.FormattingEnabled = true;
            cb_Moneda.Items.AddRange(new object[] { "USD - Dolar estadounidense", "MXN - Peso mexicano", "CAD - Dolar canadiense", "EUR - Euro", "JPY - Yen japones" });
            cb_Moneda.Location = new Point(28, 43);
            cb_Moneda.Name = "cb_Moneda";
            cb_Moneda.Size = new Size(225, 28);
            cb_Moneda.TabIndex = 1;
            // 
            // txt_Monto
            // 
            txt_Monto.Location = new Point(267, 44);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(125, 27);
            txt_Monto.TabIndex = 2;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(270, 84);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(94, 29);
            btn_Calcular.TabIndex = 3;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(23, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 366);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbl_conversiones
            // 
            lbl_conversiones.AutoSize = true;
            lbl_conversiones.Location = new Point(55, 128);
            lbl_conversiones.Name = "lbl_conversiones";
            lbl_conversiones.Size = new Size(96, 20);
            lbl_conversiones.TabIndex = 5;
            lbl_conversiones.Text = "Conversiones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 533);
            Controls.Add(lbl_conversiones);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Calcular);
            Controls.Add(txt_Monto);
            Controls.Add(cb_Moneda);
            Controls.Add(lbl_monto);
            Controls.Add(lbl_moneda);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_moneda;
        private Label lbl_monto;
        private ComboBox cb_Moneda;
        private TextBox txt_Monto;
        private Button btn_Calcular;
        private PictureBox pictureBox1;
        private Label lbl_conversiones;
    }
}
