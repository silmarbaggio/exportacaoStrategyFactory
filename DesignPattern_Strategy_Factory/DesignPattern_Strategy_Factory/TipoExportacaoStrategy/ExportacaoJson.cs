using DesignPattern_Strategy_Factory.Dominio;
using DesignPattern_Strategy_Factory.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPattern_Strategy_Factory.TipoExportacaoStrategy
{
    public class ExportacaoJson : IExportacao
    {
        public string Exportacao(string caminho, List<Cliente> clientes)
        {
            string c = caminho + "exportacao.json";

            StreamWriter write = new StreamWriter(c, false, Encoding.GetEncoding("ISO-8859-1"));

            write.WriteLine(PrepararLinhaArquivoJson(clientes));

            write.Close();
            write.Dispose();

            return c;
        }

        public string PrepararLinhaArquivoJson(List<Cliente> clientes)
        {
            string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
            return json;
        }
    }



}
