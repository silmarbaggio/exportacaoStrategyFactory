using DesignPattern_Strategy_Factory.Dominio;
using DesignPattern_Strategy_Factory.Factory;
using DesignPattern_Strategy_Factory.TipoExportacaoStrategy;
using System.Collections.Generic;

namespace DesignPattern_Strategy_Factory
{
    public class ExportarArquivo
    {
        public string ExportarArquivoPorTipo (TipoExportacaoEnum tipoExportacaoEnum, string caminho, List<Cliente> clientes )
        {
            var factory = new ConcreteExportacaoFactory().ObterTipoExportacao(tipoExportacaoEnum);
            return factory.Exportacao(caminho, clientes);
        }

    }
}
