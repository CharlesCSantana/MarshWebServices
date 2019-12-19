using ListagemModeloNegocio.Context;
using ListagemModeloNegocio.Interfaces;
using ListagemModeloNegocio.Models;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ListagemModeloNegocio.Repositories
{
    public class ModeloNegocioRepository : IModeloNegocioRepository
    {
        private readonly MarshContext _context;

        public ModeloNegocioRepository(MarshContext context)
        {
            _context = context;
        }

        public List<ModeloNegocio> BuscarModeloNegocios(int linhaSeguroAllId)
        {
            var linhaSeguroAllParam = new OracleParameter("v_id_linha_de_seguro_all", OracleDbType.Int32, linhaSeguroAllId, ParameterDirection.Input);
            var modeloNegociosParam = new OracleParameter("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

            var modeloNegocios = _context.ModeloNegocios.SqlQuery("BEGIN pkg_modelo_negocio.listar_c1(:v_id_linha_de_seguro_all, :p_cursor); END;", linhaSeguroAllParam, modeloNegociosParam).ToList();

            return modeloNegocios != null && modeloNegocios.Any() ? modeloNegocios : null;
        }
    }
}