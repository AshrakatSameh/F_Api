using api.Models;

namespace api.Interfaces
{
    public interface IDeptService
    {
        Task<IEnumerable<Dept>> GetAll();

        Task<Dept> GetById(int id);

        Task<Dept> Post(Dept dept);


        Task<Dept> Put(Dept dept);


        Task<Dept> Delete(int id);
    }
}
