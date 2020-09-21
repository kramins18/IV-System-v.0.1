using AutoMapper;
using InternetVeikals.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternetVeikals.Helpers
{
   
    public static class EntityExtensions
    {
        /// <summary>
        /// Converts the current object to the desired type using AutoMapper
        /// </summary>
        /// <typeparam name="TSource">Source type</typeparam>
        /// <typeparam name="TDestination">The type to which the object will be converted</typeparam>
        /// <param name="entity">The object to be converted</param>
        /// <returns>Object of the desired type</returns>
        /*        public static TDestination Map<TSource, TDestination>(this TSource entity)
                    where TSource : BaseEntity
                    where TDestination : BaseVM
                {
                    return Mapper.Map<TSource, TDestination>(entity);
                }*/



        // TODO: Summary
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
