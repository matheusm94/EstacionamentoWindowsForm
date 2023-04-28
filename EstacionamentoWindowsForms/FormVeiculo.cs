using SistemaEstacionamento.Model;
using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormVeiculo : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;
        public FormVeiculo(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvaVeiculo_Click(object sender, EventArgs e)
        {
            var marca = txtMarca.Text;
            var moddelo = txtModelo.Text;
            var placa = txtPlaca.Text;
            var cpfCliente = txtCpfClienteVeiculo.Text;

            var cliente = _estacionamentoService.BuscaClientePorCpf(cpfCliente);

            Veiculo veiculo = new Veiculo
            {
                Id_cliente = cliente.Id,
                Marca = marca,
                Modelo = moddelo,
                Placa = placa,
            };

            _estacionamentoService.CadastrarVeiculo(veiculo);
        }
    }
}
