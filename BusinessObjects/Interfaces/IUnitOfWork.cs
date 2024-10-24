namespace Entities.Interfaces;

public interface IUnitOfWork
{
    ValueTask SaveChanges();
}

