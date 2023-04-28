using NpgsqlTypes;
using SistemaEstacionamento.Model;
using SistemaEstacionamento.Repository;
using System.ComponentModel;

namespace SistemaEstacionamento.Service
{
    public interface IEstacionamentoService
    {
        Cliente BuscaClientePorId(int id);
        public void CadastrarVeiculo();
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
        //private readonly EstacionamentoRepository _estacionamentoRepository;
        private readonly IEstacionamentoRepository _repository;

        public EstacionamentoService(IEstacionamentoRepository repository)
        {
            _repository = repository;
        }

        public void CadastrarVeiculo()
        {
            Console.Clear();

            Veiculo veiculo = new Veiculo();

            Console.WriteLine("Digite o cpf do cliente");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite a marca");
            var marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo");
            var modelo = Console.ReadLine();

            Console.WriteLine("Digite a placa");
            var placa = Console.ReadLine();

            var cliente = BuscaClientePorCpf(cpf);

            veiculo = new Veiculo
            {
                Id_cliente = cliente.Id,
                Marca = marca,
                Modelo = modelo,
                Placa = placa
            };

            _repository.InserirVeiculo(veiculo);
            Console.WriteLine("Veiculo cadastrado com sucesso ...");
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
            Console.WriteLine("Cliente cadastrado com sucesso ...");
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
            Console.Clear();

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
            Console.Clear();

            //Console.WriteLine("Digite a placa do carro");
            //var placa = Console.ReadLine();
            var horarioSaida = DateTime.Now;

            _repository.InsereSaida(horarioSaida, placa);
        }

        public List<EntradaSaida> BuscaMovimentacoes()
        {
            return _repository.BuscaMovimentacao();
        }

    }

}
