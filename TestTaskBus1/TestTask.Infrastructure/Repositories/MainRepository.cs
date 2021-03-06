﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestTask.Core.Entities;
using TestTask.Core.Repositories;

namespace TestTask.Infrastructure.Repositories
{
    internal sealed class MainRepository : IMainRepository
    {
        private readonly DataContext _ctx;
        private readonly DbSet<Main> _dbSet;

        public MainRepository(DataContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<Main>();
        }

        public void Count(Main entity)
        {
            entity.Count++;
        }

        public void Add(Main entity)
        {
            _dbSet.Add(entity);
        }

        public async Task<Main> FindById(Guid id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Main> FindByUrl(string url)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.EditableUrl == url);
        }


        public async Task<IEnumerable<Main>> List()
        {
            return await _ctx.Main.OrderBy(x => x.Date).ToListAsync();
        }

        public void Remove(Main entity)
        {
            _dbSet.Remove(entity);
        }
    }
}