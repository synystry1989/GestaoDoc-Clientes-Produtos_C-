using System;
using System.Data;
using System.Windows.Forms;

namespace Vmp_C__ex1

{

    public partial class FrmDados : Form
    {
        public DsDocumentos dsDocumentos = new DsDocumentos();
        public DsClientes dsClientes = new DsClientes();
        public DsArtigos dsArtigos = new DsArtigos();

        public DataRow RowSelecionada;
        public FrmDados()
        {
            InitializeComponent();
        }

        public void MostrarTabelaDados(string tabela)
        {

            if (tabela == "DsClientes")
            {
                dsDocumentos.CarregaClientes();
                DgridDados.DataSource = dsDocumentos.Clientes;
            }
            else if (tabela == "DsArtigos")
            {
                dsDocumentos.CarregaArtigos();
                DgridDados.DataSource = dsDocumentos.Artigos;
                DgridDados.Columns["PrecoUnt"].DefaultCellStyle.Format = "F2";
            }

            else if (tabela == "Clientes")
            {

                dsClientes.CarregaClientes();
                DgridDados.DataSource = dsClientes.Clientes;
            }

            else if (tabela == "Artigos")
            {
                dsArtigos.CarregaArtigos();
                DgridDados.DataSource = dsArtigos.Artigos;
                DgridDados.Columns["PrecoUnt"].DefaultCellStyle.Format = "F2";
            }

            DgridDados.Refresh();
            ShowDialog();

        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (DgridDados.CurrentRow.Cells.Count > 0)
                {
                    RowSelecionada = ((DataRowView)DgridDados.CurrentRow.DataBoundItem).Row;

                    if (RowSelecionada != null)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Selecionar Artigo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void BtnVoltar_Click(object sender, System.EventArgs e)
        {
            try
            {
                RowSelecionada = null;
                DialogResult = DialogResult.Cancel;
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encerrar ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgridDados_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F4)
                {
                    if (DgridDados.CurrentRow.Cells.Count > 0)
                    {
                        RowSelecionada = ((DataRowView)DgridDados.CurrentRow.DataBoundItem).Row;

                        if (RowSelecionada != null)
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Selecionar Artigo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

