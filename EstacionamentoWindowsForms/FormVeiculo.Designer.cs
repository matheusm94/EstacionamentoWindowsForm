namespace EstacionamentoWindowsForms
{
    partial class FormVeiculo
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
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtPlaca = new TextBox();
            lblMarca = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            btnSalvaVeiculo = new Button();
            lblCpfClienteVeiculo = new Label();
            txtCpfClienteVeiculo = new TextBox();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(27, 98);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(190, 23);
            txtModelo.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(28, 38);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(190, 23);
            txtMarca.TabIndex = 1;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(28, 155);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(190, 23);
            txtPlaca.TabIndex = 2;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(32, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(141, 15);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Digite a marca do veiculo";
            lblMarca.Click += lblMarca_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(27, 75);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(150, 15);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Digite o modelo do veículo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(27, 138);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(136, 15);
            lblPlaca.TabIndex = 5;
            lblPlaca.Text = "Digite a placa do veículo";
            // 
            // btnSalvaVeiculo
            // 
            btnSalvaVeiculo.Location = new Point(279, 196);
            btnSalvaVeiculo.Name = "btnSalvaVeiculo";
            btnSalvaVeiculo.Size = new Size(84, 40);
            btnSalvaVeiculo.TabIndex = 6;
            btnSalvaVeiculo.Text = "Salvar";
            btnSalvaVeiculo.UseVisualStyleBackColor = true;
            btnSalvaVeiculo.Click += btnSalvaVeiculo_Click;
            // 
            // lblCpfClienteVeiculo
            // 
            lblCpfClienteVeiculo.AutoSize = true;
            lblCpfClienteVeiculo.Location = new Point(28, 195);
            lblCpfClienteVeiculo.Name = "lblCpfClienteVeiculo";
            lblCpfClienteVeiculo.Size = new Size(123, 15);
            lblCpfClienteVeiculo.TabIndex = 7;
            lblCpfClienteVeiculo.Text = "Digite o cpf do cliente";
            // 
            // txtCpfClienteVeiculo
            // 
            txtCpfClienteVeiculo.Location = new Point(27, 213);
            txtCpfClienteVeiculo.Name = "txtCpfClienteVeiculo";
            txtCpfClienteVeiculo.Size = new Size(190, 23);
            txtCpfClienteVeiculo.TabIndex = 8;
            // 
            // FormVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 267);
            Controls.Add(txtCpfClienteVeiculo);
            Controls.Add(lblCpfClienteVeiculo);
            Controls.Add(btnSalvaVeiculo);
            Controls.Add(lblPlaca);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(txtPlaca);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Name = "FormVeiculo";
            Text = "FormVeiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtPlaca;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblPlaca;
        private Button btnSalvaVeiculo;
        private Label lblCpfClienteVeiculo;
        private TextBox txtCpfClienteVeiculo;
    }
}