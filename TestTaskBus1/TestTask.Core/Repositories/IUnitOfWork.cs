using System;

namespace TestTask.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMainRepository MainRepository { get; }

        void Commit();
    }
}