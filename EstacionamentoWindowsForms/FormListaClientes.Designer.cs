namespace EstacionamentoWindowsForms
{
    partial class FormListaClientes
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
            dtListaDeClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtListaDeClientes).BeginInit();
            SuspendLayout();
            // 
            // dtListaDeClientes
            // 
            dtListaDeClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListaDeClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, CPF });
            dtListaDeClientes.Location = new Point(77, 134);
            dtListaDeClientes.Name = "dtListaDeClientes";
            dtListaDeClientes.RowTemplate.Height = 25;
            dtListaDeClientes.Size = new Size(594, 256);
            dtListaDeClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // FormListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtListaDeClientes);
            Name = "FormListaClientes";
            Text = "FormListaClientes";
            ((System.ComponentModel.ISupportInitialize)dtListaDeClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtListaDeClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
    }
}