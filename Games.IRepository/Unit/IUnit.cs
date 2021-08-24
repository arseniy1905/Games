using System;

namespace Games.IRepository.Unit
{
    public interface IUnit : IDisposable
    {
        //IRepositoryQueryable Queryable { get; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        void SetUserId(int userId);
        
    }
}
