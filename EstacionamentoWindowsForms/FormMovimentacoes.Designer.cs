namespace EstacionamentoWindowsForms
{
    partial class FormMovimentacoes
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
            dtMovimentacoes = new DataGridView();
            Placa = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Horario_de_saida = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtMovimentacoes).BeginInit();
            SuspendLayout();
            // 
            // dtMovimentacoes
            // 
            dtMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMovimentacoes.Columns.AddRange(new DataGridViewColumn[] { Placa, dataGridViewTextBoxColumn1, Horario_de_saida });
            dtMovimentacoes.Location = new Point(151, 142);
            dtMovimentacoes.Name = "dtMovimentacoes";
            dtMovimentacoes.RowTemplate.Height = 25;
            dtMovimentacoes.Size = new Size(475, 192);
            dtMovimentacoes.TabIndex = 0;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Horario de entrada";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Horario_de_saida
            // 
            Horario_de_saida.HeaderText = "Horario de saida";
            Horario_de_saida.Name = "Horario_de_saida";
            // 
            // FormMovimentacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtMovimentacoes);
            Name = "FormMovimentacoes";
            Text = "FormMovimentacoes";
            ((System.ComponentModel.ISupportInitialize)dtMovimentacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtMovimentacoes;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Horario_de_saida;
    }
}