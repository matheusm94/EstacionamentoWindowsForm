using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormPrincipal : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;

        //public FormPrincipal()
        //{
        //    InitializeComponent();
        //}

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
    }
}