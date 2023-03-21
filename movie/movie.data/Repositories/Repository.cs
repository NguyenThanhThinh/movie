using Microsoft.EntityFrameworkCore;
using movie.data.Data;

namespace movie.data.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    public Repository(MovieDbContext context)
    {
        Context = context ?? throw new ArgumentNullException(nameof(context));
        DbSet = Context.Set<TEntity>();
    }

    protected DbSet<TEntity> DbSet { get; set; }

    protected MovieDbContext Context { get; set; }

    public virtual IQueryable<TEntity> All()
    {
        return DbSet;
    }

    public virtual IQueryable<TEntity> AllAsNoTracking()
    {
        return DbSet.AsNoTracking();
    }

    public virtual Task AddAsync(TEntity entity)
    {
        return DbSet.AddAsync(entity).AsTask();
    }

    public virtual void Update(TEntity entity)
    {
        var entry = Context.Entry(entity);
        if (entry.State == EntityState.Detached) DbSet.Attach(entity);

        entry.State = EntityState.Modified;
    }

    public virtual void Delete(TEntity entity)
    {
        DbSet.Remove(entity);
    }

    public Task<int> SaveChangesAsync()
    {
        return Context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing) Context?.Dispose();
    }
}