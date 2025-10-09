using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using MauiApp1.Components.model;

namespace MauiApp1.Components.DAO
{
 public class ClienteDAO
    {
        public async Task<bool>SalvarCliente(Cliente novoCliente)
        {
            try
            {
                //string de conexão com o banco de dados MySQL
                string connectionString = "server=localhost;user=root;password=root;database=gatinhos";

                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string sql = "INSERT INTO tb_cliente (nome,cpf,telefone) VALUES(@nome,@telefone,@telefone)";

                await using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", novoCliente.nome);
                cmd.Parameters.AddWithValue("@cpf", novoCliente.cpf);
                cmd.Parameters.AddWithValue("@telefone", novoCliente.telefone);

                int rows = await cmd.ExecuteNonQueryAsync();

                return rows > 0;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Cliente>> ListarCliente()
        {
            var lista = new List<Cliente>();

            try
            {
                //string de conexão com o banco de dados MySQL
                string connectionString = "server=localhost;user=root;password=root;database=gatinhos";

                await using var conn = new MySqlConnection(connectionString);
                await conn.OpenAsync();

                string sql = "SELECT * FROM tb_cliente";

                await using var cmd = new MySqlCommand( sql, conn);

                await using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var cliente = new Cliente()
                    {
                        nome = reader.GetString(1),
                        cpf = reader.GetString(2),
                        telefone = reader.GetString(3)
                    };

                    lista.Add(cliente);
                }
                return lista;
            }

            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
    }
}
