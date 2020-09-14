using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using  dllBanco;
using System.Data;

namespace ConceitoMVC.Modelo
{
    public class dbBaseModel
    {
        public bool CadastroCliente(ClienteModel cli, ref string status)
        {
            bool ret = false;

            dbCliente cliente = new dbCliente();

            cliente.Idade = cli.Idade;
            cliente.NomeCliente = cli.NomeCliente;
            cliente.Sexo = cli.Sexo;

            ret = cliente.Salvar(ref status);

            return ret;
        }

        public DataSet ConsultaTodosClientes(ref string status)
        {
            DataSet ret = new DataSet();

            dbCliente cliente = new dbCliente();

            ret = cliente.ListaClientes(ref status);

            return ret;
        }
    }
}
