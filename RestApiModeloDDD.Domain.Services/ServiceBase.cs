using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<Tentity> : IServiceBase<Tentity> where Tentity : class
    {

        private readonly IrepositoryBase<Tentity> _repository;
        public ServiceBase(IrepositoryBase<Tentity> repository)
        {
            this._repository = repository;
        }
        public void Add(Tentity obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _repository.GetAll();
        }

        public Tentity GetBId(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Tentity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(Tentity obj)
        {
            _repository.Update(obj);
        }
    }
}
