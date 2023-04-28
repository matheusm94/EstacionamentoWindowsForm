using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    public partial class FormMovimentacoes : Form
    {
        private readonly IEstacionamentoService _estacionamentoService;

        public FormMovimentacoes(IEstacionamentoService estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
            InitializeComponent();
            this.Shown += new System.EventHandler(this.dataGridView1_Show);
        }

        private void dataGridView1_Show(object sender, EventArgs e)
        {
            var movimentacoes = _estacionamentoService.BuscaMovimentacoes();

            if (movimentacoes != null)
            {
                foreach (var movimentacao in movimentacoes)
                {
                    dtMovimentacoes.Rows.Add(movimentacao.PlacaVeiculo, movimentacao.HorarioEntrada, movimentacao.HorarioSaida);

                }
            }
            else
            {
                MessageBox.Show($"Não existem movimentações cadastradas.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
