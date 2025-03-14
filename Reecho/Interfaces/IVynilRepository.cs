namespace Domain;

public interface IVynilRepository
{
     public Task<List<Vynil>> GetAllVynils();
     public Task<Vynil> GetVynilById(Guid id);
     public Task CreateVynil(Vynil vynil);
     public Task UpdateVynil(Vynil vynil);
     public Task DeleteVynil(Guid id);
}