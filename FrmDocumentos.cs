using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vmp_C__ex1.DsDocumentos;


namespace Vmp_C__ex1
{
    public partial class FrmDocumentos : Form
    {
        DsClientes dsClientes = new DsClientes();

        public FrmDocumentos()
        {
            InitializeComponent();
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {
            try
            {
                FormatarTabelas();
                DsDocumentos.CarregaTipoDoc();
                TxtCodigoDoc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LimparFormulario();
                DocAtivo.Checked = true;
                DsDocumentos.NovoDocumento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Criar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult yesNo = MessageBox.Show("Deseja Eliminar o Documento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DsDocumentos.CabecDocumento[0] != null && yesNo == DialogResult.Yes)
                {
                    DsDocumentos.CabecDocumento[0].Estado = false;
                    DsDocumentos.UpdateDoc();
                    LimparFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Eliminar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CabecDocumentoRow rowAtual = DsDocumentos.CabecDocumento[0];

                if (ValidaPrenchimento())
                {
                    rowAtual.TipoDocumento = TxtCodigoDoc.Text;
                    rowAtual.NrDocumento = (int)NrDoc.Value;
                    rowAtual.Cliente = TxtCodigoCl.Text;
                    rowAtual.Telefone = TxtContato.Text;
                    rowAtual.NIF = int.Parse(TxtNif.Text);
                    rowAtual.Morada = TxtMorada.Text;
                    rowAtual.DataModificacao = DateTime.Now;
                    rowAtual.Estado = DocAtivo.Checked;
                    rowAtual.NomeCliente = TxtNomeCl.Text;

                    DsDocumentos.UpdateDoc();

                    DsDocumentos.UpdateLinhas();

                    LimparFormulario();
                }
            }
            catch (Exception ex)
            {
                if (ValidaPrenchimento() == false)
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCodigoCl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.F4)
                {
                    FrmDados frmDados = new FrmDados();

                    string tabela = "DsClientes";

                    frmDados.MostrarTabelaDados(tabela);


                    
                        var rowEscolhida = frmDados.RowSelecionada as ClientesRow;

                        if (rowEscolhida != null && rowEscolhida.Estado)
                        {
                            TxtCodigoCl.Text = rowEscolhida.CodigoCl;
                            TxtNomeCl.Text = rowEscolhida.Nome;
                            TxtMorada.Text = rowEscolhida.Morada;
                            TxtNif.Text = rowEscolhida.NIF.ToString();
                            TxtContato.Text = rowEscolhida.Telefone;
                        }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Clientes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TxtCodigoDoc_Leave(object sender, EventArgs e)
        {
            try
            {
                TipoDocumentosRow tipoRow = DsDocumentos.TipoDocumentos.FindByCodigoDoc(TxtCodigoDoc.Text);

                if (tipoRow != null)
                {
                    TxtDescricaoDoc.Text = tipoRow.Descricao;
                    NrDoc.Value = DsDocumentos.DaNrDocSeguinte(TxtCodigoDoc.Text);
                    DocAtivo.Checked = true;
                    LimparCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar", "Erro", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

            }
        }
        private void NrDoc_Leave(object sender, EventArgs e)
        {
            {
                PreencheDocumento(TxtCodigoDoc.Text, (int)NrDoc.Value);
            }
        }

        private void DocAtivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (DocAtivo.Checked)
                {
                    HabilitarBotoes();
                    HabilitarCampos();
                }
                else if (DocAtivo.Checked = false)
                {
                    DesabilitarBotoes();
                    DesabilitarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgridArtigos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal total = Convert.ToDecimal(DgridArtigos.Rows[e.RowIndex].Cells["PrecoUntDataGridViewTextBoxColumn"].Value) * Convert.ToDecimal(DgridArtigos.Rows[e.RowIndex].Cells["QuantidadeDataGridViewTextBoxColumn"].Value);
                DgridArtigos.Rows[e.RowIndex].Cells["TotalDataGridViewTextBoxColumn"].Value = Math.Round(total, 2);
            }
            catch
            {
                Exception ex = new Exception();
            }
        }
        //nova linha artigos
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                string tabela = "DsArtigos";
                FrmDados frmDados = new FrmDados();

                frmDados.MostrarTabelaDados(tabela);

                if (frmDados.DialogResult == DialogResult.OK)
                {
                    ArtigosRow rowEscolhida = frmDados.RowSelecionada as ArtigosRow;
                    if (rowEscolhida != null)
                    {
                        DsDocumentos.NovaLinhaArtigos(rowEscolhida);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //eliminar linha
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgridArtigos.CurrentRow.Cells.Count > 0)
                {
                    Guid id = Guid.Parse(DgridArtigos.CurrentRow.Cells["IDDataGridViewTextBoxColumn"].Value.ToString());

                    if (id != null)
                    {
                        DsDocumentos.EliminarLinha(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Eliminar Documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnCima_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgridArtigos.CurrentRow.Cells.Count > 0)
                {
                    Guid id = Guid.Parse(DgridArtigos.CurrentRow.Cells["IDDataGridViewTextBoxColumn"].Value.ToString());
                    if (id != null)
                    {
                        DsDocumentos.SubirLinha(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao subir linha ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBaixo_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgridArtigos.CurrentRow.Cells.Count > 0)
                {
                    Guid id = Guid.Parse(DgridArtigos.CurrentRow.Cells["IDDataGridViewTextBoxColumn"].Value.ToString());
                    if (id != null)
                    {
                        LinhasDocumentoRow rowSelecionada = DsDocumentos.LinhasDocumento.FindByID(id);

                        if (rowSelecionada.NumLinha < DgridArtigos.RowCount)
                        {
                            DsDocumentos.DescerLinha(id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao descer linha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClientes frmClientes = new FrmClientes();
                frmClientes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Clientes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void artigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmArtigos frmArtigos = new FrmArtigos();
                frmArtigos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Artigos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void PreencheDocumento(string tipoDoc, int nrDoc)
        {
            try
            {
                CabecDocumentoRow RowPesquisada = DsDocumentos.PesquisaDocumento(tipoDoc, nrDoc);

                if (RowPesquisada.Cliente != "")
                {
                    DocAtivo.Checked = RowPesquisada.Estado;
                    DataMod.Text = RowPesquisada.DataModificacao.ToString();
                    TxtCodigoCl.Text = RowPesquisada.Cliente;
                    TxtNomeCl.Text = DsDocumentos.CarregaNomeCliente(TxtCodigoCl.Text);
                    TxtMorada.Text = RowPesquisada.Morada;
                    TxtNif.Text = RowPesquisada.NIF.ToString();
                    TxtContato.Text = RowPesquisada.Telefone;

                    DsDocumentos.CarregaLinhas(RowPesquisada.ID);

                    if (DocAtivo.Checked != true)
                    {
                        DesabilitarBotoes();
                        DesabilitarCampos();
                    }
                }
                else
                {
                    NrDoc.Value = DsDocumentos.DaNrDocSeguinte(TxtCodigoDoc.Text);
                    DocAtivo.Checked = true;
                    LimparCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Preencher documento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Boolean ValidaPrenchimento()
        {
            try
            {
                //retorna se nao for uma string nula ou com espaços em branco
                return !string.IsNullOrWhiteSpace(TxtCodigoCl.Text) &&
               !string.IsNullOrWhiteSpace(TxtDescricaoDoc.Text) &&
               !string.IsNullOrWhiteSpace(TxtContato.Text) &&
               !string.IsNullOrWhiteSpace(TxtMorada.Text) &&
               !string.IsNullOrWhiteSpace(TxtNif.Text) &&
               !string.IsNullOrWhiteSpace(DataMod.Text) &&
               !string.IsNullOrEmpty(TxtNomeCl.Text) &&
               !string.IsNullOrWhiteSpace(TxtDescricaoDoc.Text) &&
               !string.IsNullOrEmpty(NrDoc.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha corretamente todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void FormatarTabelas()
        {
            DgridArtigos.Columns["PrecoUntDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "F2";
            DgridArtigos.Columns["QuantidadeDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "F2";
            DgridArtigos.Columns["IDDataGridViewTextBoxColumn"].Visible = false;
            DgridArtigos.Columns["CabecDocumentoIDDataGridViewTextBoxColumn"].Visible = false;
            DgridArtigos.Sort(DgridArtigos.Columns["NumLinhaDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
        }
        private void DesabilitarCampos()
        {
            DataMod.Enabled = false;
            TxtCodigoCl.Enabled = false;
            TxtContato.Enabled = false;
            TxtMorada.Enabled = false;
            TxtNif.Enabled = false;
            DocAtivo.Checked = false;
        }
        private void HabilitarCampos()
        {
            DataMod.Enabled = true;
            TxtCodigoCl.Enabled = true;
            TxtContato.Enabled = true;
            TxtMorada.Enabled = true;
            TxtNif.Enabled = true;
        }

        private void LimparCliente()
        {
            DataMod.Text = "";
            TxtNomeCl.Text = "";
            TxtCodigoCl.Text = "";
            TxtContato.Text = "";
            TxtMorada.Text = "";
            TxtNif.Text = String.Empty;

            DsDocumentos.LinhasDocumento.Clear();
        }
        private void LimparFormulario()
        {
            NrDoc.Value = 0;
            TxtCodigoDoc.Text = "";
            TxtDescricaoDoc.Text = "";
            DataMod.Text = "";
            TxtNomeCl.Text = "";
            TxtCodigoCl.Text = "";
            TxtContato.Text = "";
            TxtMorada.Text = "";
            TxtNif.Text = String.Empty;
            DsDocumentos.Clientes.Clear();
            DsDocumentos.CabecDocumento.Clear();
            DsDocumentos.LinhasDocumento.Clear();
        }
        private void DesabilitarBotoes()
        {
            BtnNovo.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCima.Enabled = false;
            BtnBaixo.Enabled = false;
            gravarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
        }
        private void HabilitarBotoes()
        {
            BtnNovo.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnCima.Enabled = true;
            BtnBaixo.Enabled = true;
            gravarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenUrl();
        }

        private async Task OpenUrl()
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate("https://vimaponto.azurewebsites.net");
    }

      
    }
}
