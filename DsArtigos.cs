using Vmp_C__ex1.DsArtigosTableAdapters;

namespace Vmp_C__ex1
{
    partial class DsArtigos
    {

        ArtigosTableAdapter adpArtigos = new ArtigosTableAdapter();

        public void CarregaArtigos()
        {
            adpArtigos.Fill(Artigos);
        }

        public void UpdateArtigos()
        {
            adpArtigos.Update(Artigos);
        }
        public string DaUltimoCodArtigo()
        {
            return (string)adpArtigos.DaUltimoCodArtigo();
        }

        public void NovoArtigo()
        {
            if (Artigos.Rows.Count == 0)
            {
                ArtigosRow novoArtigo = (ArtigosRow)Artigos.NewRow();

                novoArtigo.CodArtigo = "";
                novoArtigo.NomeArtigo = "";
                novoArtigo.Observacao = "";
                novoArtigo.PrecoUnt = 0;
                novoArtigo.Unidade = "";
                novoArtigo.Estado = true;

                Artigos.Rows.Add(novoArtigo);
            }
        }
        public ArtigosRow PesquisarArtigo(string codArtigo)
        {
            adpArtigos.FillByCodArtigo(Artigos, codArtigo);

            if (Artigos.Rows.Count > 0)
            {

                return Artigos[0];
            }
            else
            {
                NovoArtigo();
                return Artigos[0];
            }

        }
    }
}
