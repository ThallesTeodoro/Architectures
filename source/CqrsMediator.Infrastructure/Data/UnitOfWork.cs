using CqrsMediator.Domain.Contracts.Persistence;

namespace CqrsMediator.Infrastructure.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Rollback()
    {
        _context.Dispose();
    }
}
