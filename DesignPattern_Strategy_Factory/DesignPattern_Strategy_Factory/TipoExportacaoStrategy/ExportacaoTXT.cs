using DesignPattern_Strategy_Factory.Dominio;
using DesignPattern_Strategy_Factory.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPattern_Strategy_Factory.TipoExportacaoStrategy
{
    public class ExportacaoTXT : IExportacao
    {
        public string Exportacao(string caminho, List<Cliente> ListaCliente)
        {
            string c = caminho + "exportacao.txt";
            StreamWriter write = new StreamWriter(c, false, Encoding.GetEncoding("ISO-8859-1"));

            foreach (Cliente cliente in ListaCliente)
            {
                write.WriteLine(PrepararLinhaArquivoTexto(cliente));
            }

            write.Close();
            write.Dispose();

            return c;
        }

        public string PrepararLinhaArquivoTexto(Cliente cliente)
        {
            string linhaFormatada = string.Empty;

            linhaFormatada += cliente.Codigo.ToString().PadRight(5);
            linhaFormatada += cliente.Nome.ToString().PadRight(60);

            return linhaFormatada;
        }
    }
}
