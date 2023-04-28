using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormEntradaVeiculo : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;
        public FormEntradaVeiculo(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            var placa = txtPlacaVeiculo.Text;

            var veiculoEntrada = _estacionamentoService.BuscaVeiculoPorPlaca(placa);
            if (veiculoEntrada != null)
            {
                _estacionamentoService.CadastraEntrada(placa);
            }
            else
            {
                MessageBox.Show($"Veiculo com placa {placa} não encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
