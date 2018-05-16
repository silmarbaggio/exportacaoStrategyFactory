using DesignPattern_Strategy_Factory.Interfaces;
using DesignPattern_Strategy_Factory.TipoExportacaoStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Strategy_Factory.Factory
{
    // essa é classe abstrata que serve como contrato para a implementação da classe que vai
    // retornar a instancia correta de acordo com tipo de negocio solicitado
    // funciona bem para ser utiliza com o desing pattern Strategy

    public abstract class ExportacaoFactory
    {
        public abstract IExportacao ObterTipoExportacao(TipoExportacaoEnum tipo);
    }
}
