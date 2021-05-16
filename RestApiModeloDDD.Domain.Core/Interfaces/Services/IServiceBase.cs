using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<Tentity> where Tentity: class
    {
        void Add(Tentity obj);
        void Update(Tentity obj);
        void Remove(Tentity obj);
        IEnumerable<Tentity> GetAll();
        Tentity GetBId(int id);
    }
}
