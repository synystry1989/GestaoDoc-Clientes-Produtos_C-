using Vmp_C__ex1.DsClientesTableAdapters;



namespace Vmp_C__ex1
{
    partial class DsClientes
    {
        public ClientesTableAdapter adpClientes = new ClientesTableAdapter();


        public void CarregaClientes()
        {
            Clientes.Clear();
            adpClientes.Fill(Clientes);
        }
        public void UpdateClientes()
        {
            adpClientes.Update(Clientes);
        }

        public string DaUltimoCodCliente()
        {
            return (string)adpClientes.DaUltimoCodCL();
        }

        public void NovoCliente()
        {
            if (Clientes.Rows.Count == 0)
            {
                ClientesRow novoCliente = (ClientesRow)Clientes.NewRow();

                novoCliente.CodigoCl = "";
                novoCliente.Nome = "";
                novoCliente.Morada = "";
                novoCliente.Telefone = "";
                novoCliente.NIF = 0;
                novoCliente.Email = "";
                novoCliente.Estado = true;

                Clientes.AddClientesRow(novoCliente);
            }
        }

        public ClientesRow PesquisaCliente(string codCl)
        {
            adpClientes.FillByCodCl(Clientes, codCl);

            if (Clientes.Rows.Count > 0)
            {
                return Clientes[0];
            }
            NovoCliente();
            return Clientes[0];
        }

    }

}
