using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Entities;

namespace TestTask.Core.Repositories
{
    public interface IMainRepository
    {
        Task<Main> Find(Guid id);
        Task<IEnumerable<Main>> List();
        void Remove(Main entity);
        void Count(Main entity);
    }
}