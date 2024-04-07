using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface IMainLetterService
    {
        Task<IEnumerable<MainLetter>> GetAll();

        Task<MainLetter> GetById(int id);

        Task<MainLetter> Add(MainLetterDto dto);


        Task<MainLetter> Update(int id, MainLetterDto dto);


        Task<MainLetter> Delete(int id);
    }
}
