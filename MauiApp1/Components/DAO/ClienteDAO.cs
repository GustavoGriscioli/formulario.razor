using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace MauiApp1.Components.DAO
{
 public class ClienteDAO 
    {
        public async Task<bool>SalvarCliente(ClienteDAO novoCliente)
        {
            try
            {
                //string de conexão com o banco de dados MySQL
                string connectionString = "server=localhost;user=root;password=root;database=gatinhos";

                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string sql = "INSERT INTO tb_cliente (nome,cpf,telefone) VALUES(@nome,@telefone,@telefone)";
            }

            catch (Exception ex)
            {

            }
        }
    }
}
