namespace EstacionamentoWindowsForms
{
    partial class FormEntradaVeiculo
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
            btnRegistrarEntrada = new Button();
            txtPlacaVeiculo = new TextBox();
            lblEntradaVeiculo = new Label();
            lblSaidaVeiculo = new Label();
            btnRegistrarSaida = new Button();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.Location = new Point(268, 103);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(122, 23);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Cadastrar entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // txtPlacaVeiculo
            // 
            txtPlacaVeiculo.Location = new Point(34, 103);
            txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            txtPlacaVeiculo.Size = new Size(210, 23);
            txtPlacaVeiculo.TabIndex = 1;
            // 
            // lblEntradaVeiculo
            // 
            lblEntradaVeiculo.AutoSize = true;
            lblEntradaVeiculo.Location = new Point(38, 76);
            lblEntradaVeiculo.Name = "lblEntradaVeiculo";
            lblEntradaVeiculo.Size = new Size(136, 15);
            lblEntradaVeiculo.TabIndex = 3;
            lblEntradaVeiculo.Text = "Digite a placa do veículo";
            lblEntradaVeiculo.Click += label1_Click;
            // 
            // lblSaidaVeiculo
            // 
            lblSaidaVeiculo.AutoSize = true;
            lblSaidaVeiculo.Location = new Point(34, 165);
            lblSaidaVeiculo.Name = "lblSaidaVeiculo";
            lblSaidaVeiculo.Size = new Size(203, 15);
            lblSaidaVeiculo.TabIndex = 4;
            lblSaidaVeiculo.Text = "Clique no botão para registrar a saída";
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.Location = new Point(268, 165);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(122, 23);
            btnRegistrarSaida.TabIndex = 5;
            btnRegistrarSaida.Text = "Registrar saída";
            btnRegistrarSaida.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(97, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(257, 28);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Registrar entrada do veículo";
            // 
            // FormMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 219);
            Controls.Add(lblHeader);
            Controls.Add(btnRegistrarSaida);
            Controls.Add(lblSaidaVeiculo);
            Controls.Add(lblEntradaVeiculo);
            Controls.Add(txtPlacaVeiculo);
            Controls.Add(btnRegistrarEntrada);
            Name = "FormMovimentacao";
            Text = "FormMovimentacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEntrada;
        private TextBox txtPlacaVeiculo;
        private Label lblEntradaVeiculo;
        private Label lblSaidaVeiculo;
        private Button btnRegistrarSaida;
        private Label lblHeader;
    }
}