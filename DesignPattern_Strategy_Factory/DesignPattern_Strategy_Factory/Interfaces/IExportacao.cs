using DesignPattern_Strategy_Factory.Dominio;
using System.Collections.Generic;

namespace DesignPattern_Strategy_Factory.Interfaces
{
    public interface  IExportacao
    {
        string Exportacao(string caminho, List<Cliente> ListaCliente);
    }
}
