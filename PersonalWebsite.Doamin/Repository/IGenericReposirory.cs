using PersonalWebsite.Doamin.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalWebsite.Doamin.Repository
{
    public interface IGenericRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetQuery();
        Task AddEntity(TEntity entity);
        Task<TEntity> GetEntityById(long entityId);
        void EditEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        Task DeleteEntityBy(long entityId);
        void DeletePermanent(TEntity entity);
        void DeletePhysically(TEntity entity);
        Task SaveChanges();
    }
}
