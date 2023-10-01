using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuLivroDeReceitas.Domain.Extension
{
    public static class RepositorioExtension
    {
        // o this serve parar usar a indicar a extension
        public static string GetDatabaseName(this IConfiguration configurationManager)
        {
            var conexao = configurationManager.GetConnectionString("DatabaseName");

            return conexao;
        }

        public static string GetConexao(this IConfiguration configurationManager)
        {
            var conexao = configurationManager.GetConnectionString("Conexao");

            return conexao;
        }
    }
}
