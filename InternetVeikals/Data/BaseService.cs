using InternetVeikals.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public abstract class BaseService<TEntity> where TEntity : BaseEntity, new()
    {
        protected Context _context { get; set; }

        public BaseService(IServiceProvider services)
        {
            _context = services.GetService<Context>();
        }

        public virtual async Task<List<TEntity>> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            var entityQuery = _context.Set<TEntity>().AsQueryable();
            entityQuery.Include()
            entityQuery = entityQuery.AssignIncludes(include);
            var entitiesList = await entityQuery.ToListAsync();
            return entitiesList;
        }

        public virtual async Task<TEntity> GetByIdAsync(long id)
        {
            var entityQuery = _context.Set<TEntity>().AsQueryable();
            var entity = await entityQuery.FirstOrDefaultAsync(x => x.Id == id);
            return entity;

        }
        public static IQueryable<TEntity> AssignIncludes<TEntity>(this IQueryable<TEntity> query, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null) where TEntity : BaseEntity
        {
            if (include != null)
            {
                query = include(query);
            }
            return query;
        }
    }
}