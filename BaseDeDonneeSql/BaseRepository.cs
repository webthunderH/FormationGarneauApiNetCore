﻿using BaseDeDonneeSql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity:class
    {
        internal DbContextGarneau context;
        internal Microsoft.EntityFrameworkCore.DbSet<TEntity> DbSet=> context.Set<TEntity>();

        public BaseRepository(DbContextGarneau context)
        {
            this.context = context;
            
        }

        public void Delete(TEntity entityToDelete)
        {
            context.Remove(entityToDelete);
        }
              

        public Task<List<TEntity>> Get()
        {
            return DbSet.ToListAsync();
        }

        public Task<TEntity> GetBy(Expression<Func<TEntity, bool>> exp)
        {
            return DbSet.FirstOrDefaultAsync(exp);
        }

       
        public void Insert(TEntity entity)
        {
            context.Add(entity);
        }

        public void Update(TEntity entityToUpdate)
        {
            context.Update(entityToUpdate);
        }
    }
}
