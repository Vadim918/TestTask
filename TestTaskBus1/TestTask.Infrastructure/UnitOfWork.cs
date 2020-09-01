using System;
using TestTask.Core.Repositories;
using TestTask.Infrastructure.Repositories;

namespace TestTask.Infrastructure
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private DataContext _context;
        private bool _isDisposed;
        private IMainRepository _mainRepository;

        private DataContext Context => _context ??= new DataContext();
        public IMainRepository MainRepository => _mainRepository ??= new MainRepository(Context);

        public void Dispose()
        {
            if (_context == null) return;

            if (!_isDisposed) Context.Dispose();

            _isDisposed = true;
        }

        public void Commit()
        {
            if (_isDisposed) throw new ObjectDisposedException("UnitOfWork");

            Context.SaveChanges();
        }
    }
}