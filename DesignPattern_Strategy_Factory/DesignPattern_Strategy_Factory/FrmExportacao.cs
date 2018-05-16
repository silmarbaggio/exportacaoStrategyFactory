using DesignPattern_Strategy_Factory.Dominio;
using DesignPattern_Strategy_Factory.TipoExportacaoStrategy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DesignPattern_Strategy_Factory
{
    public partial class FrmExportacao : Form
    {
        public FrmExportacao()
        {
            InitializeComponent();
            txtCaminho.Text = @"C:\Exportacao\";
        }
        #region [Evento]
        private void FrmExportacao_Load(object sender, EventArgs e)
        {
            //carregar o combo com um lista vindo de enum
            this.cboTipoExportacao.DataSource = DeEnumParaList<TipoExportacaoEnum>();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                var listaClientes = new ClienteRepository().GetListaClientes();

                TipoExportacaoEnum tipo = (TipoExportacaoEnum)cboTipoExportacao.SelectedItem;
                var expo = new ExportarArquivo();
                var caminhoCompleto = expo.ExportarArquivoPorTipo(tipo, txtCaminho.Text, listaClientes);

                MostrarArquivo(caminhoCompleto);

                MessageBox.Show("Exportação gerada com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region [Metodos]
        /// <summary>
        /// Metodo para transformar um enum com seus valores em uma lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> DeEnumParaList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T Não é um Enum");

            IList<T> list = new List<T>();
            Type tipo = typeof(T);
            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);
                foreach (T value in enumValores)
                {
                    list.Add(value);
                }
            }

            return list;
        }
        private void MostrarArquivo(string caminhoCompleto)
        {
            string text = File.ReadAllText(caminhoCompleto);
            txtResultado.Text = text;
        }

        #endregion
    }
}
