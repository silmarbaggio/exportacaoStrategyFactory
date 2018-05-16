using System.Collections.Generic;
using System.Text;
using System.Xml;
using DesignPattern_Strategy_Factory.Dominio;
using DesignPattern_Strategy_Factory.Interfaces;

namespace DesignPattern_Strategy_Factory.TipoExportacaoStrategy
{
    public class ExportacaoXML : IExportacao
    {
        public string  Exportacao(string caminho, List<Cliente> ListaCliente)
        {
            string caminhoComNome = caminho + "exportacao.xml";
            XmlTextWriter escritorXML = new XmlTextWriter(caminhoComNome, Encoding.UTF8);
            escritorXML.Formatting = Formatting.Indented;

            //iniciando o documento
            escritorXML.WriteStartDocument();
            //escrevendo o elemento raiz do documento
            escritorXML.WriteStartElement("Clientes");

            foreach (Cliente item in ListaCliente)
            {
                escritorXML.WriteStartElement("Cliente");

                escritorXML.WriteAttributeString("Codigo", item.Codigo.ToString());
                escritorXML.WriteAttributeString("Nome", item.Nome);
                escritorXML.WriteEndElement();
            }

            //fechando o elemento raiz
            escritorXML.WriteEndElement();
            //fechando o documento
            escritorXML.WriteEndDocument();
            escritorXML.Close();

            return caminhoComNome;
        }
    }
}
