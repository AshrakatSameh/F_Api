using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface IMainEx
    {
        Task<IEnumerable<MainEx>> GetAll();
        Task<MainEx> GetById(int id);
        Task<MainEx> Add(MainExDto dto);
        Task<MainEx> Update(int id, MainExDto dto);
        Task<MainEx> Delete(int id);
    }
}
