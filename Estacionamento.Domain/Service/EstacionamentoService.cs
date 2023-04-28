using SistemaEstacionamento.Model;
using SistemaEstacionamento.Repository;

namespace SistemaEstacionamento.Service
{
    public interface IEstacionamentoService
    {
        Cliente BuscaClientePorId(int id);
        public void CadastrarVeiculo(Veiculo veiculo);
        public void CadastrarCliente(Cliente cliente);
        List<Veiculo> ListVeiculos();
        public List<Cliente> ListaClientes();
        public Cliente BuscaClientePorCpf(string cpf);
        void CadastraEntrada(string placa);
        void CadastraSaida(string placa);
        EntradaSaida BuscaMovimentacaoPorPlaca(string placa);
        List<EntradaSaida> BuscaMovimentacoes();
        Veiculo BuscaVeiculoPorPlaca(string placa);
    }

    public class EstacionamentoService : IEstacionamentoService
    {
        private readonly IEstacionamentoRepository _repository;

        public EstacionamentoService(IEstacionamentoRepository repository)
        {
            _repository = repository;
        }

        public void CadastrarVeiculo(Veiculo veiculo)
        {
            _repository.InserirVeiculo(veiculo);
        }

        public Veiculo BuscaVeiculoPorPlaca(string placa)
        {
            return _repository.BuscaVeiculoPorPlaca(placa);
        }

        public Cliente BuscaClientePorId(int id)
        {
            return _repository.BuscaClientePorId(id);
        }
        public void CadastrarCliente(Cliente cliente)
        {
            _repository.InserirCliente(cliente);
        }

        public List<Cliente> ListaClientes()
        {
            return _repository.ListaClientes();
        }

        public Cliente BuscaClientePorCpf(string cpf)
        {
            return _repository.GetByCpf(cpf);
        }

        public List<Veiculo> ListVeiculos()
        {
            return _repository.ListVeiculos();
        }

        public void CadastraEntrada(string placa)
        {
            var entrada = new EntradaSaida
            {
                PlacaVeiculo = placa,
                HorarioEntrada = DateTime.Now
            };

            _repository.InsereEntrada(entrada);
        }

        public EntradaSaida BuscaMovimentacaoPorPlaca(string placa)
        {
            return _repository.BuscaMovimentacaoPorPlaca(placa);
        }

        public void CadastraSaida(string placa)
        {
            var horarioSaida = DateTime.Now;

            _repository.InsereSaida(horarioSaida, placa);
        }

        public List<EntradaSaida> BuscaMovimentacoes()
        {
            return _repository.BuscaMovimentacao();
        }
    }
}
