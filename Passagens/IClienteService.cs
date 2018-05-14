using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat =WebMessageFormat.Json, UriTemplate ="addCliente/{nome};{cpf}")]
        void Add(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat =WebMessageFormat.Json, UriTemplate ="searchCliente/{nome}")]
        Cliente Buscar(string nome);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")]
        List<Cliente> getClientes();
    }
}
