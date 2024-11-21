using System;
using System.Data;
using System.Linq;
using Vmp_C__ex1.DsDocumentosTableAdapters;

namespace Vmp_C__ex1
{
    partial class DsDocumentos
    {
        public CabecDocumentoTableAdapter adpCabecDocumento = new CabecDocumentoTableAdapter();
        public TipoDocumentosTableAdapter adpTipoDocumentos = new TipoDocumentosTableAdapter();
        public ClientesTableAdapter adpClientes = new ClientesTableAdapter();
        public LinhasDocumentoTableAdapter adpLinhas = new LinhasDocumentoTableAdapter();
        public ArtigosTableAdapter adpArtigos = new ArtigosTableAdapter();


        public void CarregaTipoDoc()
        {
            adpTipoDocumentos.Fill(TipoDocumentos);
        }

       public void CarregaArtigos()
        {
            Artigos.Clear();
            adpArtigos.Fill(Artigos);
        }

        public void CarregaClientes()
        {
            Clientes.Clear();
            adpClientes.Fill(Clientes);
        }

        public void CarregaDocumento(string tipo, int nr)
        {
            CabecDocumento.Clear();
            adpCabecDocumento.FillByTipo_Nr_Doc(CabecDocumento, tipo, nr);
        }

        public void CarregaLinhas(Guid id)
        {
            adpLinhas.FillByCabecID(LinhasDocumento, id);
        }

        public void UpdateDoc()
        {
            adpCabecDocumento.Update(CabecDocumento);
        }

        public void UpdateLinhas()
        {
            adpLinhas.Update(LinhasDocumento);
        }

        public string CarregaNomeCliente(string codCl)
        {
            return adpClientes.DaNomeCliente(codCl);
        }

        public int DaNrDocSeguinte(string tipoDoc)
        {        /*cast explicito*/
            return (int)adpCabecDocumento.CountTipoDoc(tipoDoc) + 1;
        }

        public CabecDocumentoRow PesquisaDocumento(string tipoDoc, int nrDoc)
        {
            CarregaDocumento(tipoDoc, nrDoc);

            if (CabecDocumento.Rows.Count > 0)
            {
                return CabecDocumento[0];
            }
            else
            {
                NovoDocumento();
                return CabecDocumento[0];
            }
        }

        public void NovoDocumento()
        {
            if (CabecDocumento.Rows.Count == 0)
            {
                CabecDocumentoRow newDocRow = (CabecDocumentoRow)CabecDocumento.NewRow();
                newDocRow.ID = Guid.NewGuid();
                newDocRow.TipoDocumento = "";
                newDocRow.NrDocumento = 0;
                newDocRow.DataModificacao = DateTime.Now;
                newDocRow.Cliente = "";
                newDocRow.NomeCliente = "";
                newDocRow.Morada = "";
                newDocRow.NIF = 0;
                newDocRow.Telefone = "";
                newDocRow.Estado = true;
                LinhasDocumento.Clear();

                CabecDocumento.Rows.Add(newDocRow);
            }
        }

        public void NovaLinhaArtigos(ArtigosRow rowSelecionada)
        {
            NovoDocumento();

            LinhasDocumentoRow novaLinha = LinhasDocumento.NewRow() as LinhasDocumentoRow;

            novaLinha.ID = Guid.NewGuid();
            novaLinha.CabecDocumentoID = CabecDocumento[0].ID;

            int contador = 0;
            //para nao contemplar as linhas eliminadas
            foreach (LinhasDocumentoRow row in LinhasDocumento.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    contador++;
                }
            }
            novaLinha.NumLinha = contador + 1;
            novaLinha.Descricao = rowSelecionada.NomeArtigo;
            novaLinha.Artigo = rowSelecionada.CodArtigo;
            novaLinha.Quantidade = (decimal)0.00;
            novaLinha.PrecoUnt = rowSelecionada.PrecoUnt;
            novaLinha.DataEntrega = DateTime.Now;
            novaLinha.Total = (decimal)0.00;
            novaLinha.EstadoProduto = rowSelecionada.Estado;

            LinhasDocumento.AddLinhasDocumentoRow(novaLinha);
        }

        public void EliminarLinha(Guid id)
        {
            LinhasDocumentoRow linhaSelecionada = LinhasDocumento.FindByID(id);

            foreach (LinhasDocumentoRow row in LinhasDocumento.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row.NumLinha > linhaSelecionada.NumLinha)
                {
                    row.NumLinha -= 1;
                }
            }
            //if (linhaSelecionada != null)
            //{
            //    linhaSelecionada.Delete();
            //}
            linhaSelecionada?.Delete();
        }

        public void SubirLinha(Guid id)
        {
            LinhasDocumentoRow rowSelecionada = LinhasDocumento.FindByID(id);
            if (rowSelecionada != null)
            {
                int indiceLinhaSelecionada = rowSelecionada.NumLinha;
                if ((indiceLinhaSelecionada - 1) > 0)
                {
                    LinhasDocumentoRow rowAnterior = LinhasDocumento.Where(x => x.RowState != DataRowState.Deleted && x.NumLinha.Equals(indiceLinhaSelecionada - 1)).FirstOrDefault();
                    if (rowAnterior != null)
                    {
                        rowAnterior.NumLinha = indiceLinhaSelecionada;
                        rowSelecionada.NumLinha = indiceLinhaSelecionada - 1;
                    }
                }
            }
        }

        public void DescerLinha(Guid id)
        {
            LinhasDocumentoRow rowSelecionada = LinhasDocumento.FindByID(id);
            if (rowSelecionada != null)
            {
                int indiceLinhaSelecionada = rowSelecionada.NumLinha;

                LinhasDocumentoRow rowSeguinte = LinhasDocumento.Where(x => x.RowState != DataRowState.Deleted && x.NumLinha.Equals(indiceLinhaSelecionada + 1)).FirstOrDefault();
                if (rowSeguinte != null)
                {
                    rowSeguinte.NumLinha = indiceLinhaSelecionada;
                    rowSelecionada.NumLinha = indiceLinhaSelecionada + 1;
                }
            }
        }
    }
}

