using System.Collections.Generic;

namespace DesignPattern_Strategy_Factory.Dominio
{
    public class ClienteRepository
    {
        public List<Cliente> GetListaClientes()
        {
            return new List<Cliente>
            {
                new Cliente {Codigo = 100, Nome = "AFABESP" },
                new Cliente {Codigo = 200, Nome = "SIMPRO"},
                new Cliente {Codigo = 300, Nome = "ITAU"},
                new Cliente {Codigo = 400, Nome = "HOSPITAL SANTA CATARINA"}
            };
        }

    }
}
