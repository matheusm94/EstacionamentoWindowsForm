using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormSaidaVeiculo : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;
        public FormSaidaVeiculo(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
        }

        private void btnRegistrarSaida_Click(object sender, EventArgs e)
        {
            var placa = txtPlacaVeiculo.Text;

            var veiculoEntrada = _estacionamentoService.BuscaVeiculoPorPlaca(placa);
            if (veiculoEntrada != null)
            {
                _estacionamentoService.CadastraSaida(placa);
                var preco = _estacionamentoService.CalculaPrecoPorPlaca(placa);

                lblPreco.Text = preco.ToString();

                dynamic recibo = new
                {
                    Placa = placa,
                    Preco = preco
                };

                _estacionamentoService.SaveFile(recibo, "recibo.json");
            }
            else
            {
                MessageBox.Show($"Veiculo com placa {placa} não encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
