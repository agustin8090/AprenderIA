using System;
using AprenderIA.Domain.IRepositorys;
using AprenderIA.Domain.Entities;


namespace AprenderIA.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    public Task CreateUserAsync(User user, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(User user, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserAsync(Guid id, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<User>> GetUsersAsync(CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(User user, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task UserExistAsync(Guid id, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}
