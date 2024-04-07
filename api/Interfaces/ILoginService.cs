using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ILoginService
    {
        Task<IEnumerable<Login>> GetAll();

        Task<Login> GetById(int id);

        Task<Login> Add(LoginDto dto);


        Task<Login> Update(int id, LoginDto dto);


        Task<Login> Delete(int id);
    }
}
