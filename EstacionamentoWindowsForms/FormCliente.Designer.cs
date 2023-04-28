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
            btnSalvaCliente.Location = new Point(269, 165);
            btnSalvaCliente.Name = "btnSalvaCliente";
            btnSalvaCliente.Size = new Size(75, 23);
            btnSalvaCliente.TabIndex = 2;
            btnSalvaCliente.Text = "Salvar";
            btnSalvaCliente.UseVisualStyleBackColor = true;
            btnSalvaCliente.Click += btnSalvaCliente_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 209);
            Controls.Add(btnSalvaCliente);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Name = "Cliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private Button btnSalvaCliente;
    }
}