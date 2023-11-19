namespace Persistence;
public sealed class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext dbContext;
    public UnitOfWork(ApplicationDbContext dbContext)
    {
        this.dbContext=dbContext;
    }
    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return dbContext.SaveChangesAsync(cancellationToken);
    }
}