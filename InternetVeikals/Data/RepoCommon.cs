using InternetVeikals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public abstract class RepoCommon<TEntity> where TEntity: BaseEntity, new()
    {
        protected Context _context { get; set; }
        protected IRepository<TEntity> entity { get; set; }
        public RepoCommon(Context context)
        {
            _context = context;
        }
        public virtual async Task<List<TEntity>> Get()
        {
            var entityQuery = _context.Set<TEntity>().AsQueryable();
            var entitiesList = await entityQuery.ToListAsync();
            if (entitiesList == null)
            {
                throw new KeyNotFoundException();
            }
            return entitiesList;
        }
        public virtual async Task<TEntity> GetById(long id)
        {
            var entityQuery = _context.Set<TEntity>().AsQueryable();
            var entity = await entityQuery.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
            {
                throw new KeyNotFoundException();
            }
            return entity;
        }
        public virtual async void Save(TEntity data)
        {
            var isNewEntity = !(data.Id > 0);
            var entityQuery = _context.Set<TEntity>();
            entityQuery.Add(data);
            return await SaveChangesAsync();



        }
        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }
    }

    public interface IRepository<TEntity> where TEntity : class, new()
    {

    }
}
