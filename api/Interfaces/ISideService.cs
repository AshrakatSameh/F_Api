using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ISideService
    {
        Task<IEnumerable<Side>> GetAll();
        Task<Side> GetById(int ser);
        Task<Side> Add(SideDto dto);
        Task<Side> Update(int ser, SideDto dto);
        Task<Side> Delete(int ser);
    }
}
