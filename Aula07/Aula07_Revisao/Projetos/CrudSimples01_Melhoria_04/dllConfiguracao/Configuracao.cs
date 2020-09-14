using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace dllConfiguracao
{
    public class Configuracao
    {
        public string StrConfiguracao { get; set; }

        /// <summary>
        /// Construtor da Classe Pega a string de conexao da base do arquivo de configuração.
        /// </summary>
        public Configuracao()
        {
             StrConfiguracao = ConfigurationManager.ConnectionStrings["dbTeste"].ConnectionString;
        }


    }
}
