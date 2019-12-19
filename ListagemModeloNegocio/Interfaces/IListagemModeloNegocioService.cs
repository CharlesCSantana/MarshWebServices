using ListagemModeloNegocio.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ListagemModeloNegocio.Interfaces
{
    [ServiceContract]
    interface IListagemModeloNegocioService
    {
        [OperationContract]
        List<ModeloNegocio> BuscarModeloNegocios(int linhaSeguroAllId);
    }
}