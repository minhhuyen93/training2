﻿namespace TinyERP.Common.Common.Data
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
    }
}