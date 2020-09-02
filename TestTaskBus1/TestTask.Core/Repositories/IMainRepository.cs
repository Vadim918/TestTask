using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core.Entities;

namespace TestTask.Core.Repositories
{
    public interface IMainRepository
    {
        void Add(Main entity);
        Task<Main> FindById(Guid id);
        Task<Main> FindByUrl(string url);
        Task<IEnumerable<Main>> List();
        void Remove(Main entity);
        void Count(Main entity);
    }
}