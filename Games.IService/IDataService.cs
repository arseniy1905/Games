using System;

namespace Games.IService
{
    public interface IDataService : IDisposable
    {
        int SaveChanges();
        void SetUserId(int userId);
    }
}
