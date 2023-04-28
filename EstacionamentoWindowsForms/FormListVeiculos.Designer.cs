namespace EstacionamentoWindowsForms
{
    partial class FormListVeiculos
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
            dtListaVeiculos = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtListaVeiculos).BeginInit();
            SuspendLayout();
            // 
            // dtListaVeiculos
            // 
            dtListaVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListaVeiculos.Columns.AddRange(new DataGridViewColumn[] { Cliente, Marca, Modelo, Placa });
            dtListaVeiculos.Location = new Point(77, 152);
            dtListaVeiculos.Name = "dtListaVeiculos";
            dtListaVeiculos.RowTemplate.Height = 25;
            dtListaVeiculos.Size = new Size(616, 205);
            dtListaVeiculos.TabIndex = 0;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            // 
            // FormListVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtListaVeiculos);
            Name = "FormListVeiculos";
            Text = "FormListVeiculos";
            ((System.ComponentModel.ISupportInitialize)dtListaVeiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtListaVeiculos;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Placa;
    }
}