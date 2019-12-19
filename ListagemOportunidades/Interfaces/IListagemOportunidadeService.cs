using ListagemOportunidades.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ListagemOportunidades.Interfaces
{
    [ServiceContract]
    public interface IListagemOportunidadeService
    {
        [OperationContract]
        List<Oportunidade> ListarOportunidades(string email);

        [OperationContract]
        List<Colaborador> ListarColaboradoresTeste(string email);
    }
}