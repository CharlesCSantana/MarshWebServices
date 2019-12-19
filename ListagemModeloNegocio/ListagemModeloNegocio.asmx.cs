using ListagemModeloNegocio.Interfaces;
using ListagemModeloNegocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ListagemModeloNegocio
{
    /// <summary>
    /// Summary description for ListagemModeloNegocio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ListagemModeloNegocio : System.Web.Services.WebService
    {
        private readonly IModeloNegocioRepository _modeloNegocioRepository;

        public ListagemModeloNegocio(IModeloNegocioRepository modeloNegocioRepository)
        {
            _modeloNegocioRepository = modeloNegocioRepository;
        }

        [WebMethod(Description = "Listar Modelo Negocio")]
        public List<ModeloNegocio> ListarModeloNegocio(int linhaSeguroAllId)
        {
            return _modeloNegocioRepository.BuscarModeloNegocios(linhaSeguroAllId);
        }
    }
}
