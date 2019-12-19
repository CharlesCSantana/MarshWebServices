using ListagemOportunidades.Models;
using System.Collections.Generic;


namespace ListagemOportunidades.Interfaces
{
    public interface IOportunidadeRepository
    {
        Colaborador BuscarColaborador(string email);
        List<Oportunidade> BuscarOportunidades(int numeroSoftPeopleId, string cnpjCpf, int lincod);
    }
}