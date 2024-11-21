using System;
using System.Windows.Forms;
using static Vmp_C__ex1.DsClientes;



namespace Vmp_C__ex1
{
    public partial class FrmClientes : Form
    {
        DsClientes dsClientes = new DsClientes();
        FrmDados frmDados = new FrmDados();

        public FrmClientes()
        {
            InitializeComponent();
        }
        private void TxtCodigoCl_Leave(object sender, EventArgs e)
        {
            PreencherCliente();
        }
        private void TxtCodigoCl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {

                    frmDados.MostrarTabelaDados("Clientes");
                    PreencherCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar Clientes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClienteAtivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ClienteAtivo.Checked)
                {
                    HabilitarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ativar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                dsClientes.NovoCliente();
                LimparFormulario();
                HabilitarCampos();
                DaProxNrCliente();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao Criar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesRow RowAtual = dsClientes.Clientes[0];

                if (ValidaPrenchimento())
                {
                    RowAtual.Nome = TxtNome.Text;
                    RowAtual.CodigoCl = TxtCodigoCl.Text;
                    RowAtual.NIF = int.Parse(TxtNIF.Text);
                    RowAtual.Estado = ClienteAtivo.Checked;
                    RowAtual.Email = TxtEmail.Text;
                    RowAtual.Morada = TxtMorada.Text;
                    RowAtual.Telefone = TxtTelefone.Text;

                    dsClientes.UpdateClientes();
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
                    MessageBox.Show("Erro ao Gravar Clientw", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult yesNo = MessageBox.Show("Deseja Eliminar o Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dsClientes.Clientes[0] != null && yesNo == DialogResult.Yes)
                {
                    dsClientes.Clientes[0].Estado = false;
                    dsClientes.UpdateClientes();

                    LimparFormulario();
                    DesabilitarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Eliminar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PreencherCliente()
        {
            try
            {
                dsClientes.NovoCliente();


                if (frmDados.DialogResult != DialogResult.OK && TxtCodigoCl.Text == "")
                {
                    DaProxNrCliente();
                }
                else if (frmDados.DialogResult != DialogResult.OK)
                {
                    string codArtigo = TxtCodigoCl.Text;

                    ClientesRow clientesRow = dsClientes.PesquisaCliente(codArtigo);


                    TxtCodigoCl.Text = clientesRow.CodigoCl;
                    //coloca o ultimo nr cliente disponivel caso haja engano na insercao
                    if (clientesRow.CodigoCl == "")
                    {
                        DaProxNrCliente();
                    }
                    TxtNome.Text = clientesRow.Nome;
                    TxtMorada.Text = clientesRow.Morada;
                    TxtNIF.Text = clientesRow.NIF.ToString();
                    TxtTelefone.Text = clientesRow.Telefone;
                    TxtEmail.Text = clientesRow.Email;
                    ClienteAtivo.Checked = clientesRow.Estado;
                    if (clientesRow.Estado == false)
                    {
                        DesabilitarCampos();
                    }
                }

                //permite sempre que carreguemos f4 abrir os clientes 
                if (frmDados.DialogResult == DialogResult.OK)
                {
                    ClientesRow rowSelecionada = (ClientesRow)frmDados.RowSelecionada;

                    string codCl = rowSelecionada.CodigoCl;

                    ClientesRow clientesRow = dsClientes.PesquisaCliente(codCl);

                    TxtCodigoCl.Text = clientesRow.CodigoCl;
                    TxtNome.Text = clientesRow.Nome;
                    TxtMorada.Text = clientesRow.Morada;
                    TxtNIF.Text = clientesRow.NIF.ToString();
                    TxtTelefone.Text = clientesRow.Telefone;
                    TxtEmail.Text = clientesRow.Email;
                    ClienteAtivo.Checked = clientesRow.Estado;
                    if (clientesRow.Estado == false)
                    {
                        DesabilitarCampos();
                    }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DaProxNrCliente()
        {
            string codCl = dsClientes.DaUltimoCodCliente();
            //retiramos o CL ao cod incrementamos e voltamos a concatenar
            int valor = int.Parse(codCl.Substring(2));
            valor++;
            TxtCodigoCl.Text = "CL" + valor.ToString("000");
        }

        public Boolean ValidaPrenchimento()
        {
            //retorna se nao for uma string nula ou com espaços em branco
            return
                !string.IsNullOrWhiteSpace(TxtCodigoCl.Text) &&
                !string.IsNullOrWhiteSpace(TxtMorada.Text) &&
                !string.IsNullOrWhiteSpace(TxtTelefone.Text) &&
                !string.IsNullOrWhiteSpace(TxtNIF.Text) &&
                !string.IsNullOrEmpty(TxtNome.Text) &&
                !string.IsNullOrEmpty(TxtEmail.Text);
        }   

    private void LimparFormulario()
    {
        TxtCodigoCl.Text = "";
        TxtNome.Text = "";
        TxtTelefone.Text = "";
        TxtMorada.Text = "";
        TxtNIF.Text = String.Empty;
        TxtEmail.Text = "";
    }
    private void HabilitarCampos()
    {
        BtnEliminar.Enabled = true;
        BtnGravar.Enabled = true;
        TxtCodigoCl.Enabled = true;
        TxtEmail.Enabled = true;
        TxtMorada.Enabled = true;
        TxtNIF.Enabled = true;
        TxtTelefone.Enabled = true;
        TxtNome.Enabled = true;
    }
    private void DesabilitarCampos()
    {
        BtnEliminar.Enabled = false;
        BtnGravar.Enabled = false;
        TxtCodigoCl.Enabled = false;
        TxtEmail.Enabled = false;
        TxtMorada.Enabled = false;
        TxtNIF.Enabled = false;
        TxtTelefone.Enabled = false;
        TxtNome.Enabled = false;
    }


}
}



