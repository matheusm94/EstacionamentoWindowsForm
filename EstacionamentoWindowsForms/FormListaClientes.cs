using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormListaClientes : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;
        public FormListaClientes(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.dataGridView1_Show);
        }

        private void dataGridView1_Show(object sender, EventArgs e)
        {
            var clientes = _estacionamentoService.ListaClientes();

            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    dtListaDeClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.CPF);

                }
            }
            else
            {
                MessageBox.Show($"Não existem clientes cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
