using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface IEmpService
    {
        Task<IEnumerable<Emp>> GetAll();
        Task<Emp> GetById(int ser);
        Task<Emp> Add(EmpDto dto);
        Task<Emp> Update(int ser, EmpDto dto);
        Task<Emp> Delete(int ser);
    }
}
