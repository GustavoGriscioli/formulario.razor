using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                
                await using var conn = new MySqlConnector(connectionString)
            }

            catch
            {

            }
        }
    }
}
