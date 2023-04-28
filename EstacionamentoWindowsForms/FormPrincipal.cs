using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormPrincipal : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;

        public FormPrincipal(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente(_estacionamentoService);
            cliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormListVeiculos formListVeiculos = new FormListVeiculos(_estacionamentoService);
            formListVeiculos.Show();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo(_estacionamentoService);
            formVeiculo.Show();
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            FormEntradaVeiculo formMovimentacao = new FormEntradaVeiculo(_estacionamentoService);
            formMovimentacao.Show();
        }

        private void btnRegistrarSaida_Click(object sender, EventArgs e)
        {
            FormSaidaVeiculo formSaidaVeiculo = new FormSaidaVeiculo(_estacionamentoService);
            formSaidaVeiculo.Show();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes formListaClientes = new FormListaClientes(_estacionamentoService);
            formListaClientes.Show();
        }

        private void btnListarMovimentacoes_Click(object sender, EventArgs e)
        {
            FormMovimentacoes formMovimentacoes = new FormMovimentacoes(_estacionamentoService);
            formMovimentacoes.Show();
        }
    }
}