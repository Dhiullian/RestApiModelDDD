using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<Tentity>: IrepositoryBase<Tentity> where Tentity: class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this._sqlContext = sqlContext;
        }
        public void Add(Tentity obj)
        {
            try
            {
                _sqlContext.Set<Tentity>().Add(obj);
                _sqlContext.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _sqlContext.Set<Tentity>().ToList();
        }

        public Tentity GetById(int id)
        {
            return _sqlContext.Set<Tentity>().Find(id);
        }

        public void Remove(Tentity obj)
        {
            try
            {
                _sqlContext.Set<Tentity>().Remove(obj);
                _sqlContext.SaveChanges();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public void Update(Tentity obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            }
            catch (Exception err)
            {

                throw err;
            }
        }
    }
}
