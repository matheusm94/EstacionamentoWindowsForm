using Estacionamento.Domain.Utils;
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
        double CalculaPreco(DateTime entrada, DateTime saida);
        double CalculaPrecoPorPlaca(string placa);
        void SaveFile<T>(IEnumerable<T> file, string fileName);
        List<T> ReadFile<T>(string fileName);
    }

    public class EstacionamentoService : IEstacionamentoService
    {
        private readonly IEstacionamentoRepository _repository;
        private readonly IFileUtils _fileUtils;

        public EstacionamentoService(IEstacionamentoRepository repository, IFileUtils fileUtils)
        {
            _repository = repository;
            _fileUtils = fileUtils;
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

        public double CalculaPreco(DateTime entrada, DateTime saida)
        {
            var precoPorHora = 6;

            var horasUtilizadas = entrada - saida;

            var preco = precoPorHora * horasUtilizadas.TotalHours;
            return preco;
        }

        public double CalculaPrecoPorPlaca(string placa)
        {
            var veiculo = _repository.BuscaMovimentacaoPorPlaca(placa);
            var preco = CalculaPreco(veiculo.HorarioEntrada, (DateTime)veiculo.HorarioSaida);

            return preco;
        }

        public void SaveFile<T>(IEnumerable<T> file, string fileName)
        {
            _fileUtils.SaveFile(file, fileName);
        }
        public List<T> ReadFile<T>(string fileName)
        {
            var data = _fileUtils.ReadFile<T>(fileName);

            return data;
        }
    }
}
