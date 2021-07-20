using ContractManagement.Domain.Entities;
using ContractManagement.Domain.Repositories;
using ContractManagement.Infrastructure.Identity.Roles;
using ContractManagement.Infrastructure.Identity.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Repositories
{
    public abstract class AbstractRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : IdentityDbContext<User, Role, int>
    {
        protected readonly TContext context;

        public AbstractRepository(TContext context)
        {
            this.context = context;
        }

        // Prepare query before processing (include nested entites, etc..)
        protected virtual IQueryable<TEntity> PrepareQuery()
        {
            return this.context.Set<TEntity>();
        }

        public async virtual Task<List<TEntity>> FindAll()
        {
            return await this.PrepareQuery().ToListAsync();
        }

        public async virtual Task<TEntity> FindById(int id)
        {
            return await this.PrepareQuery().SingleOrDefaultAsync(entity => entity.ID == id);
        }

        public async virtual Task<TEntity> Create(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task<TEntity> Update(TEntity entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task<TEntity> Delete(int id)
        {
            var entity = await this.context.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                this.context.Set<TEntity>().Remove(entity);
                await this.context.SaveChangesAsync();
            }
            
            return entity;
        }
    }
}
