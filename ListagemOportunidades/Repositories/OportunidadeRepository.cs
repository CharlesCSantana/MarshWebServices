using ListagemOportunidades.Context;
using ListagemOportunidades.Interfaces;
using ListagemOportunidades.Models;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ListagemOportunidades.Repositories
{
    public class OportunidadeRepository : IOportunidadeRepository
    {
        private readonly MarshContext _context;

        public OportunidadeRepository(MarshContext context)
        {
            _context = context;
        }

        public Colaborador BuscarColaborador(string email)
        {
            var emailParam = new OracleParameter("V_EMAIL", OracleDbType.Varchar2, email, ParameterDirection.Input);
            var colaboradoresParam = new OracleParameter("P_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);

            var colaboradores = _context.Colaboradores.SqlQuery("BEGIN RETORNA_COLABORADOR(:V_EMAIL, :P_CURSOR); END;", emailParam, colaboradoresParam).ToList();

            return colaboradores != null && colaboradores.Any() ? colaboradores.FirstOrDefault() : null;
        }

        public List<Oportunidade> BuscarOportunidades(int numeroSoftPeopleId, string cnpjCpf, int lincod)
        {
            var numeroSoftPeopleParam = new OracleParameter("V_NR_PEOPLESOFT_ID", OracleDbType.Int32, numeroSoftPeopleId, ParameterDirection.Input);
            var cnpjCpfParam = new OracleParameter("V_CNPJ_CPF", OracleDbType.Varchar2, cnpjCpf, ParameterDirection.Input);
            var lincodParam = new OracleParameter("V_LINCOD", OracleDbType.Int32, lincod, ParameterDirection.Input);
            var oportunidadesParam = new OracleParameter("P_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);

            var oportunidades = _context.Oportunidades.SqlQuery("BEGIN RETORNA_OPORTUNIDADE(:V_NR_PEOPLESOFT_ID, :V_CNPJ_CPF, :V_LINCOD, :P_CURSOR); END;", numeroSoftPeopleParam, cnpjCpfParam, lincodParam, oportunidadesParam).ToList();

            return oportunidades != null ? oportunidades.ToList() : null;
        }
    }
}