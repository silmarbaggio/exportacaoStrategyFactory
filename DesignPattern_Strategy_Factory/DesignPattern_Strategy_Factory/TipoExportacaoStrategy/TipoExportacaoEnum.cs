using System.ComponentModel;

namespace DesignPattern_Strategy_Factory.TipoExportacaoStrategy
{
    public enum TipoExportacaoEnum
    {
        [Description("Formato Json")]
        Json = 1,
        [Description("Formato TXT")]
        TXT = 2,
        [Description("Formato XML")]
        XML = 3
    }
}
