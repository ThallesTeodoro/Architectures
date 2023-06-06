namespace CqrsMediator.Domain.Contracts.Persistence;

public interface IUnitOfWork
{
    void Commit();
    void Rollback();
}
