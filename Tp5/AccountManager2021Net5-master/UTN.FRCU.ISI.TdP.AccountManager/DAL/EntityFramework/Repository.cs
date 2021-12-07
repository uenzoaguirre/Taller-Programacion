﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public abstract class Repository<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class
                                                                                 where TDbContext : DbContext
    {

        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
        }

        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>();
        }

        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
