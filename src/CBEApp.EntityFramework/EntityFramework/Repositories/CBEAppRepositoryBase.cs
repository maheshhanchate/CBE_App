using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CBEApp.EntityFramework.Repositories
{
    public abstract class CBEAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CBEAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CBEAppRepositoryBase(IDbContextProvider<CBEAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CBEAppRepositoryBase<TEntity> : CBEAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CBEAppRepositoryBase(IDbContextProvider<CBEAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
