using System;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Domain.IRepositorys;

public interface IUserRepository
{

Task<ICollection<User>> GetUsersAsync(CancellationToken ct=default);
Task<User?> GetUserAsync(Guid id, CancellationToken ct=default);

Task UserExistAsync(Guid id, CancellationToken ct=default);
Task CreateUserAsync(User user, CancellationToken ct=default);
Task UpdateUserAsync(User user, CancellationToken ct=default);
Task DeleteUserAsync(User user, CancellationToken ct=default);



}
