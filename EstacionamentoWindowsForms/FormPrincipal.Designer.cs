namespace EstacionamentoWindowsForms
{
    partial class FormPrincipal
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
            btnCadastrarCliente = new Button();
            btnCadastrarVeiculo = new Button();
            btnListarClientes = new Button();
            btnListaVeiculos = new Button();
            btnRegistrarEntrada = new Button();
            btnRegistrarSaida = new Button();
            btnListarMovimentacoes = new Button();
            SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(28, 29);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(259, 29);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastrar cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnCadastrarVeiculo
            // 
            btnCadastrarVeiculo.Location = new Point(28, 76);
            btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            btnCadastrarVeiculo.Size = new Size(259, 29);
            btnCadastrarVeiculo.TabIndex = 1;
            btnCadastrarVeiculo.Text = "Cadastrar veiculo";
            btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            btnCadastrarVeiculo.Click += btnCadastrarVeiculo_Click;
            // 
            // btnListarClientes
            // 
            btnListarClientes.Location = new Point(28, 127);
            btnListarClientes.Name = "btnListarClientes";
            btnListarClientes.Size = new Size(259, 29);
            btnListarClientes.TabIndex = 2;
            btnListarClientes.Text = "Listar clientes";
            btnListarClientes.UseVisualStyleBackColor = true;
            btnListarClientes.Click += btnListarClientes_Click;
            // 
            // btnListaVeiculos
            // 
            btnListaVeiculos.Location = new Point(28, 171);
            btnListaVeiculos.Name = "btnListaVeiculos";
            btnListaVeiculos.Size = new Size(259, 29);
            btnListaVeiculos.TabIndex = 3;
            btnListaVeiculos.Text = "Listar veiculos";
            btnListaVeiculos.UseVisualStyleBackColor = true;
            btnListaVeiculos.Click += button4_Click;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.Location = new Point(28, 222);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(259, 29);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.Location = new Point(28, 272);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(259, 30);
            btnRegistrarSaida.TabIndex = 5;
            btnRegistrarSaida.Text = "Registrar saida";
            btnRegistrarSaida.UseVisualStyleBackColor = true;
            btnRegistrarSaida.Click += btnRegistrarSaida_Click;
            // 
            // btnListarMovimentacoes
            // 
            btnListarMovimentacoes.Location = new Point(28, 318);
            btnListarMovimentacoes.Name = "btnListarMovimentacoes";
            btnListarMovimentacoes.Size = new Size(259, 30);
            btnListarMovimentacoes.TabIndex = 6;
            btnListarMovimentacoes.Text = "Listar movimentações";
            btnListarMovimentacoes.UseVisualStyleBackColor = true;
            btnListarMovimentacoes.Click += btnListarMovimentacoes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 380);
            Controls.Add(btnListarMovimentacoes);
            Controls.Add(btnRegistrarSaida);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(btnListaVeiculos);
            Controls.Add(btnListarClientes);
            Controls.Add(btnCadastrarVeiculo);
            Controls.Add(btnCadastrarCliente);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarCliente;
        private Button btnCadastrarVeiculo;
        private Button btnListarClientes;
        private Button btnListaVeiculos;
        private Button btnRegistrarEntrada;
        private Button btnRegistrarSaida;
        private Button btnListarMovimentacoes;
    }
}