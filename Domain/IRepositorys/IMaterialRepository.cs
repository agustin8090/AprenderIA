using System;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Domain.IRepositorys;

public interface IMaterialRepository
{
Task< ICollection<Material>> GetMaterialsAsync(CancellationToken ct=default);
Task<Material?> GetMaterialAsync(Guid id, CancellationToken ct=default);
Task MaterialExistAsync(Guid id, CancellationToken ct=default);

//create,update,delete
Task CreateMaterialAsync(Material material, CancellationToken ct=default);
Task UpdateMaterialAsync(Material material, CancellationToken ct=default);
Task DeleteMaterialAsync(Material material, CancellationToken ct=default);

Task<MaterialSummary?> GetSummaryByMaterialIdAsync(Guid materialId, CancellationToken ct=default);
Task AddSummaryAsync(MaterialSummary summary, CancellationToken ct=default);

}
