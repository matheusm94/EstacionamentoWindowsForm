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
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
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
            // 
            // btnListarClientes
            // 
            btnListarClientes.Location = new Point(28, 127);
            btnListarClientes.Name = "btnListarClientes";
            btnListarClientes.Size = new Size(259, 29);
            btnListarClientes.TabIndex = 2;
            btnListarClientes.Text = "Listar clientes";
            btnListarClientes.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(28, 171);
            button4.Name = "button4";
            button4.Size = new Size(259, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(28, 222);
            button5.Name = "button5";
            button5.Size = new Size(259, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(508, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnListarClientes);
            Controls.Add(btnCadastrarVeiculo);
            Controls.Add(btnCadastrarCliente);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarCliente;
        private Button btnCadastrarVeiculo;
        private Button btnListarClientes;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
    }
}