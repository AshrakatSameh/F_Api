using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ISubExService
    {
        Task<IEnumerable<SubEx>> GetAll();
        Task<SubEx> GetById(int ser);
        Task<SubEx> Delete(int ser);
        Task<SubEx> Update(int ser, SubExDto dto);
        Task<SubEx> AddAsync(SubExDto dto);
    }
}
