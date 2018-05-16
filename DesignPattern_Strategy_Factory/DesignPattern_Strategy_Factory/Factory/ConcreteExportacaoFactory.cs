using System;
using DesignPattern_Strategy_Factory.Interfaces;
using DesignPattern_Strategy_Factory.TipoExportacaoStrategy;

namespace DesignPattern_Strategy_Factory.Factory
{
    public class ConcreteExportacaoFactory : ExportacaoFactory
    {
        public override IExportacao ObterTipoExportacao(TipoExportacaoEnum tipo)
        {
            // Isso é um padrão conhecido como Factory ou Factory Method
            switch (tipo)
            {
                case TipoExportacaoEnum.XML:
                    return new ExportacaoXML();
                case TipoExportacaoEnum.TXT:
                    return new ExportacaoTXT();
                case TipoExportacaoEnum.Json:
                    return new ExportacaoJson();
                default:
                    throw new ApplicationException(string.Format("Nenhum tipo conhecido foi solicitado", tipo));
            }
        }
    }
}
