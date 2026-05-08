namespace Conversor_de_monedas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            btn_Cancelar = new Button();
            btn_Aceptar = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 15);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(408, 202);
            checkedListBox1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(12, 243);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(94, 29);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(326, 243);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(94, 29);
            btn_Aceptar.TabIndex = 1;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Cancelar);
            Controls.Add(checkedListBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Cancelar;
        private Button btn_Aceptar;
        public CheckedListBox checkedListBox1;
    }
}