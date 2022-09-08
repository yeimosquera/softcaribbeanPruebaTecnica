using softcaribbeanPruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softcaribbeanPruebaTecnica.Data.Repositories
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetPersonasPacientes(int tipoPerson);
        Task<IEnumerable<Persona>> GetAllPersonas();
        Task<Persona> GetDetallePersonas(int id);
        Task<bool> InsertPersonas(Persona persona);
        Task<bool> UpdatePersonas(Persona persona);
        Task<bool> DeletePersonas(Persona persona);

    }
}
