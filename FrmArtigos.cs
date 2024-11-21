
using System;
using System.Windows.Forms;
using static Vmp_C__ex1.DsArtigos;



namespace Vmp_C__ex1
{
    public partial class FrmArtigos : Form
    {
        DsArtigos dsArtigos = new DsArtigos();
        FrmDados frmDados = new FrmDados();
        public FrmArtigos()
        {
            InitializeComponent();
        }
        private void TxtCodigoPr_Leave(object sender, EventArgs e)
        {
            PreencherArtigo();
        }
        private void TxtCodigoPr_KeyDown(object sender, KeyEventArgs e)
       {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    frmDados.MostrarTabelaDados("Artigos");
                    PreencherArtigo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar Artigos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ProdutoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ArtigoAtivo.Checked)
                {
                    HabilitarCampos();
                }
                if (ArtigoAtivo.Checked = false)
                {
                    DesabilitarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Ativar Artigo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                dsArtigos.NovoArtigo();
                LimparFormulario();
                HabilitarCampos();
                DaProxCodArtigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Criar Artigo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult yesNo = MessageBox.Show("Deseja Eliminar o Porduto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dsArtigos.Artigos[0] != null && yesNo == DialogResult.Yes)
                {
                    dsArtigos.Artigos[0].Estado = false;
                    dsArtigos.UpdateArtigos();
                    DesabilitarCampos();
                    LimparFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Eliminar Artigo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ArtigosRow rowGuardada = dsArtigos.Artigos[0];


                if (ValidaPrenchimento() && rowGuardada != null)
                {
                    rowGuardada.CodArtigo = TxtCodigoPr.Text;
                    rowGuardada.Estado = ArtigoAtivo.Checked;
                    rowGuardada.NomeArtigo = TxtNomeProduto.Text;
                    rowGuardada.Observacao = TxtObservacao.Text;
                    rowGuardada.PrecoUnt = decimal.Parse(TxtPreco.Text);
                    rowGuardada.Unidade = TxtUnidade.Text;
                    dsArtigos.UpdateArtigos();
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
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void PreencherArtigo()
        {
            try
            {
                dsArtigos.NovoArtigo();
                if (frmDados.DialogResult != DialogResult.OK && TxtCodigoPr.Text == "")
                {
                    DaProxCodArtigo();
                }
                else
                {
                    string codArtigo = TxtCodigoPr.Text;

                    ArtigosRow artigosRow = dsArtigos.PesquisarArtigo(codArtigo);
                                    
                        TxtCodigoPr.Text = artigosRow.CodArtigo;
                        if (artigosRow.CodArtigo == "")
                        {
                            DaProxCodArtigo();
                        }                                       
                        TxtNomeProduto.Text = artigosRow.NomeArtigo;
                        TxtObservacao.Text = artigosRow.Observacao;
                        TxtPreco.Text = artigosRow.PrecoUnt.ToString();
                        TxtUnidade.Text = artigosRow.Unidade;
                        ArtigoAtivo.Checked = artigosRow.Estado;
                    if (artigosRow.Estado ==false)
                    {
                        DesabilitarCampos();
                    }
                }
                if (frmDados.DialogResult == DialogResult.OK)
                {
                    ArtigosRow rowSelecionada = frmDados.RowSelecionada as ArtigosRow;

                    string codArtigo = rowSelecionada.CodArtigo;

                    ArtigosRow artigosRow = dsArtigos.PesquisarArtigo(codArtigo);
                                       
                        TxtCodigoPr.Text = artigosRow.CodArtigo;
                        TxtNomeProduto.Text = artigosRow.NomeArtigo;
                        TxtObservacao.Text = artigosRow.Observacao;
                        TxtPreco.Text = Math.Round(artigosRow.PrecoUnt, 2).ToString("F2");
                        TxtUnidade.Text = artigosRow.Unidade;
                        ArtigoAtivo.Checked = artigosRow.Estado;
                    if (artigosRow.Estado == false)
                    {
                        DesabilitarCampos();
                    }

                        frmDados.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Preencher Artigo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DaProxCodArtigo()
        {

            string codCl = dsArtigos.DaUltimoCodArtigo();
            //retiramos o CL ao cod incrementamos e voltamos a concatenar
            int valor = int.Parse(codCl.Substring(2));
            valor++;
            TxtCodigoPr.Text = "PR" + valor.ToString("000");
        }
        public Boolean ValidaPrenchimento()
        {
            //retorna se nao for uma string nula ou com espaços em branco
            return
                !string.IsNullOrWhiteSpace(TxtCodigoPr.Text) &&
                !string.IsNullOrWhiteSpace(TxtNomeProduto.Text) &&
                !string.IsNullOrWhiteSpace(TxtObservacao.Text) &&
                !string.IsNullOrWhiteSpace(TxtPreco.Text) &&
                !string.IsNullOrEmpty(TxtUnidade.Text);
        }

        public void LimparFormulario()
        {
            TxtCodigoPr.Text = "";
            TxtNomeProduto.Text = "";
            TxtObservacao.Text = "";
            TxtPreco.Text = "";
            TxtUnidade.Text = "";
            ArtigoAtivo.Checked = true;
        }
        private void HabilitarCampos()
        {
            BtnEliminar.Enabled = true;
            BtnGravar.Enabled = true;
            TxtCodigoPr.Enabled = true;
            TxtNomeProduto.Enabled = true;
            TxtObservacao.Enabled = true;
            TxtPreco.Enabled = true;
            TxtUnidade.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            BtnEliminar.Enabled = false;
            BtnGravar.Enabled = false;
            TxtCodigoPr.Enabled = false;
            TxtUnidade.Enabled = false;
            TxtPreco.Enabled = false;
            TxtObservacao.Enabled = false;
            TxtNomeProduto.Enabled = false;
        }
      
    }
}