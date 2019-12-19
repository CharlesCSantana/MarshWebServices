using ListagemModeloNegocio.Models;
using System.Collections.Generic;

namespace ListagemModeloNegocio.Interfaces
{
    public interface IModeloNegocioRepository
    {
        List<ModeloNegocio> BuscarModeloNegocios(int linhaSeguroAllId);
    }
}