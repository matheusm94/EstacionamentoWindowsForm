using Dapper;
using SistemaEstacionamento.Data;
using SistemaEstacionamento.Model;
using System.Data;

namespace SistemaEstacionamento.Repository
{
    public interface IEstacionamentoRepository
    {
        Cliente BuscaClientePorId(int id);
        Cliente GetByCpf(string cpf);
        List<Cliente> ListaClientes();
        List<Veiculo> ListVeiculos();
        void InserirCliente(Cliente cliente);
        void InserirVeiculo(Veiculo veiculo);
        Veiculo BuscaVeiculoPorPlaca(string placa);
        void InsereEntrada(EntradaSaida movimentacao);
        void InsereSaida(DateTime horario_saida, string placa);
        EntradaSaida BuscaMovimentacaoPorPlaca(string placa_veiculo);
        List<EntradaSaida> BuscaMovimentacao();
    }
    public class EstacionamentoRepository: IEstacionamentoRepository
    {
        static readonly object _addClienteLock = new object();
        private readonly IDatabaseConfig _databaseConfig;

        public EstacionamentoRepository(IDatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public Cliente BuscaClientePorId(int id)
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = "SELECT * FROM cliente WHERE Id = @Id";
                return connection.QueryFirstOrDefault<Cliente>(sql, new { Id = id });
            }
        }

        public Cliente GetByCpf(string cpf)
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = "SELECT * FROM cliente WHERE cpf = @cpf";

                return connection.QueryFirstOrDefault<Cliente>(sql, new { cpf = cpf });

            }
        }
        public List<Cliente> ListaClientes()
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = "SELECT * FROM cliente";

                return connection.Query<Cliente>(sql).ToList();

            }
        }
        public void InserirCliente(Cliente cliente)
        {
            var sql = @"insert into cliente(nome, cpf)
            values(@nome, @cpf);";

            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("Nome", cliente.Nome, DbType.String);
            parametros.Add("Cpf", cliente.CPF, DbType.String);

            lock (_addClienteLock)
            {
                using IDbConnection connection = _databaseConfig.CreateConnection();
                connection.Execute(sql, parametros);
            }
        }

        public void InserirVeiculo(Veiculo veiculo)
        {
            using var connection = _databaseConfig.CreateConnection();
            connection.Open();

            var sql = @"insert into veiculo(id_cliente, marca, modelo, placa) 
            values (@IdCliente, @Marca, @Modelo, @Placa)";

            var id = connection.ExecuteScalar<int>(sql, veiculo);
        }

        public List<Veiculo> ListVeiculos()
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = "SELECT * FROM veiculo v " +
                    "inner join cliente c on v.id_cliente = c.id";

                return connection.Query<Veiculo>(sql).ToList();

            }
        }

        public Veiculo BuscaVeiculoPorPlaca(string placa)
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = "SELECT * FROM veiculo where placa = @placa";

                return connection.QueryFirstOrDefault<Veiculo>(sql, new { placa = placa });

            }
        }

        public void InsereEntrada(EntradaSaida movimentacao)
        {
            using var connection = _databaseConfig.CreateConnection();
            connection.Open();

            var sql = @"insert into entradasaida(placaveiculo, horarioentrada, horariosaida)
                        values(@placaveiculo, @horarioentrada, @horariosaida)";

            var id = connection.ExecuteScalar<int>(sql, movimentacao);
        }

        public void InsereSaida(DateTime horario_saida, string placa)
        {
            using var connection = _databaseConfig.CreateConnection();
            connection.Open();

            var sql = @"update entradasaida
                    set horariosaida = @horario_saida
                    where placaveiculo = @placa";

            var lineUpdated = connection.Execute(sql, new { horario_saida, placa });

        }

        public EntradaSaida BuscaMovimentacaoPorPlaca(string placaVeiculo)
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = "SELECT * FROM entradasaida where placaveiculo = @placaveiculo";

                return connection.QueryFirstOrDefault<EntradaSaida>(sql, new { placaveiculo = placaVeiculo });
            }
        }

        public List<EntradaSaida> BuscaMovimentacao()
        {
            using (var connection = _databaseConfig.CreateConnection())
            {
                connection.Open();
                var sql = @"SELECT * FROM entradasaida";

                return connection.Query<EntradaSaida>(sql).ToList();
            }
        }
    }
}
