using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormListVeiculos : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;
        public FormListVeiculos(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
            this.Shown += new System.EventHandler(dataGridView1_Show);
        }

        private void dataGridView1_Show(object sender, EventArgs e)
        {
            var veiculos = _estacionamentoService.ListVeiculos();

            if (veiculos != null)
            {
                foreach (var veiculo in veiculos)
                {
                    var cliente = _estacionamentoService.BuscaClientePorId(veiculo.Id_cliente).Nome;
                    dtListaVeiculos.Rows.Add(cliente, veiculo.Marca, veiculo.Modelo, veiculo.Placa);
                }
            }
            else
            {
                MessageBox.Show($"Não existem clientes cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
