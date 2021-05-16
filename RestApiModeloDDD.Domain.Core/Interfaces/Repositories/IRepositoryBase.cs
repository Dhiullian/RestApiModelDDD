﻿using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositories
{
    public interface IrepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
