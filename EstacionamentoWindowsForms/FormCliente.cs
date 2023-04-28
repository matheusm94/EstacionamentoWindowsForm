using SistemaEstacionamento.Model;
using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{

    public partial class FormCliente : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;

        public FormCliente(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
        }

        private void btnSalvaCliente_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;

            var cpf = txtCpf.Text;

            Cliente cliente = new Cliente
            {
                CPF = cpf,
                Nome = nome,
            };

            _estacionamentoService.CadastrarCliente(cliente);
        }
    }
}
