using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace MauiApp1.Components.model
{
    public class Cliente
    {
        public string nome { get; set; } = string.Empty;
        public string cpf { get; set; } = string.Empty;
        public string telefone { get; set; } = string.Empty;
        
        public static Cliente UltimoCliente { get; set; }
    }

}
