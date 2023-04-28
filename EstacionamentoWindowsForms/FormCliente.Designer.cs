namespace EstacionamentoWindowsForms
{
    partial class FormCliente
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
            txtNome = new TextBox();
            txtCpf = new TextBox();
            btnSalvaCliente = new Button();
            lblNome = new Label();
            lblCpf = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(298, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(46, 85);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(298, 23);
            txtCpf.TabIndex = 1;
            // 
            // btnSalvaCliente
            // 
            btnSalvaCliente.Location = new Point(269, 137);
            btnSalvaCliente.Name = "btnSalvaCliente";
            btnSalvaCliente.Size = new Size(75, 23);
            btnSalvaCliente.TabIndex = 2;
            btnSalvaCliente.Text = "Salvar";
            btnSalvaCliente.UseVisualStyleBackColor = true;
            btnSalvaCliente.Click += btnSalvaCliente_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(48, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(137, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Digite o nome do cliente";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(49, 66);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(123, 15);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "Digite o cpf do cliente";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 190);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(btnSalvaCliente);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Name = "FormCliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private Button btnSalvaCliente;
        private Label lblNome;
        private Label lblCpf;
    }
}