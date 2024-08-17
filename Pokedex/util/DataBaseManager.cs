using MySql.Data.MySqlClient;
using System.Data;

namespace Pokedex.util
{
    class DataBaseManager : IDisposable
    {
        private readonly MySqlConnection _conexao;

        public DataBaseManager(string stringDeConexao)
        {
            _conexao = new MySqlConnection(stringDeConexao);
        }

        public int AtualizarBanco(string comandoDML)
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand(comandoDML, _conexao))
                {
                    _conexao.Open();
                    return comando.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Log do erro (opcional)
                Console.WriteLine($"Erro ao executar comando DML: {ex.Message}");
                return -1;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public DataTable ConsultarBanco(string comandoDQL)
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand(comandoDQL, _conexao))
                {
                    _conexao.Open();
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        DataTable tabela = new DataTable();
                        tabela.Load(leitor);
                        return tabela;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Log do erro (opcional)
                // Console.WriteLine($"Erro ao executar comando DQL: {ex.Message}");
                return null;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Dispose()
        {
            _conexao.Dispose();
        }
    }
}
