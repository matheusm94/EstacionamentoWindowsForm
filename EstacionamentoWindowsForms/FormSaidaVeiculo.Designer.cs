namespace EstacionamentoWindowsForms
{
    partial class FormSaidaVeiculo
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
            btnRegistrarSaida = new Button();
            label1 = new Label();
            lblRegistrarSaida = new Label();
            txtPlacaVeiculo = new TextBox();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.Location = new Point(290, 97);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(119, 23);
            btnRegistrarSaida.TabIndex = 0;
            btnRegistrarSaida.Text = "Registrar saída";
            btnRegistrarSaida.UseVisualStyleBackColor = true;
            btnRegistrarSaida.Click += btnRegistrarSaida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 20);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 1;
            label1.Text = "Registrar saída do veículo";
            // 
            // lblRegistrarSaida
            // 
            lblRegistrarSaida.AutoSize = true;
            lblRegistrarSaida.Location = new Point(27, 70);
            lblRegistrarSaida.Name = "lblRegistrarSaida";
            lblRegistrarSaida.Size = new Size(136, 15);
            lblRegistrarSaida.TabIndex = 2;
            lblRegistrarSaida.Text = "Digite a placa do veículo";
            // 
            // txtPlacaVeiculo
            // 
            txtPlacaVeiculo.Location = new Point(27, 97);
            txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            txtPlacaVeiculo.Size = new Size(227, 23);
            txtPlacaVeiculo.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(27, 137);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(70, 15);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço total: ";
            lblPreco.Click += label2_Click;
            // 
            // FormSaidaVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 173);
            Controls.Add(lblPreco);
            Controls.Add(txtPlacaVeiculo);
            Controls.Add(lblRegistrarSaida);
            Controls.Add(label1);
            Controls.Add(btnRegistrarSaida);
            Name = "FormSaidaVeiculo";
            Text = "FormSaidaVeiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarSaida;
        private Label label1;
        private Label lblRegistrarSaida;
        private TextBox txtPlacaVeiculo;
        private Label lblPreco;
    }
}