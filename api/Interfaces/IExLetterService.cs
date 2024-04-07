using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface IExLetterService
    {
        Task<IEnumerable<Exletter>> GetAll();

        Task<Exletter> GetById(int id);

        Task<Exletter> Add(ExLetterDto dto);


        Task<Exletter> Update(int ser, ExLetterDto dto);


        Task<Exletter> Delete(int id);
    }
}
