﻿using EBookStoreCore.Data.Abstract;
using EBookStoreCore.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreCore.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _dbContext;

        public EfEntityRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext; //db context ef coredan gelen inject ettik

        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => _dbContext.Set<TEntity>().Remove(entity));//remove metodu async olmadığı için biz oluşturduk

        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();//entitileri query de tuttuk
            if (predicate != null)
            {
                query = query.Where(predicate);//eğer predicate null değilse sorgulayacak

            }
            if (includeProperties.Any()) //includepropery de değer var mı kontrol ediyoruz varsa
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);//birden fazla değer gelirse foreach ile hepsini alıp includeProperties dizisine atayacağız

                }

            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();//entitileri query de tuttuk
            if (predicate != null)
            {
                query = query.Where(predicate);//eğer predicate null değilse sorgulayacak

            }
            if (includeProperties.Any()) //includepropery de değer var mı kontrol ediyoruz varsa
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);//birden fazla değer gelirse foreach ile hepsini alıp includeProperties dizisine atayacağız

                }

            }
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _dbContext.Set<TEntity>().Update(entity));
        }
    }
}
