
using System.Collections.Generic;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.Cpf = cpf;
            ClienteDAO dao = new ClienteDAO();
            dao.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(nome);
        }

        public List<Cliente> getClientes()
        {
            return ClienteDAO.clientes;
        }
    }
}
