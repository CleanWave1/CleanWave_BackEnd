using CleanWave_Backend.Shared.Domain.Repositories;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext Context;
    protected BaseRepository(AppDbContext context) => Context = context;

    public async Task AddSync(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);
    public async Task<TEntity?> FindByIdAsync(int id) => await Context.Set<TEntity>().FindAsync(id);
    
    public void Update(TEntity entity) => Context.Set<TEntity>().Update(entity);
    public void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);
    public async Task<IEnumerable<TEntity>> ListAsync() => await Context.Set<TEntity>().ToListAsync();
}