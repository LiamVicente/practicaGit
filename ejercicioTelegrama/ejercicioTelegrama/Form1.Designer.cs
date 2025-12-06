namespace ejercicioTelegrama
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
            lblTexto = new Label();
            txtTelegrama = new TextBox();
            chkUrgente = new CheckBox();
            lblCoste = new Label();
            txtPrecio = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(37, 49);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(42, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(37, 79);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(604, 220);
            txtTelegrama.TabIndex = 1;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(37, 331);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(73, 19);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // lblCoste
            // 
            lblCoste.AutoSize = true;
            lblCoste.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoste.Location = new Point(37, 397);
            lblCoste.Name = "lblCoste";
            lblCoste.Size = new Size(41, 15);
            lblCoste.TabIndex = 3;
            lblCoste.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(100, 394);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(465, 355);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(113, 34);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtPrecio);
            Controls.Add(lblCoste);
            Controls.Add(chkUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(lblTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtTelegrama;
        private CheckBox chkUrgente;
        private Label lblCoste;
        private TextBox txtPrecio;
        private Button btnCalcular;
    }
}
