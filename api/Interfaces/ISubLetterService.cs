using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ISubLetterService
    {
        Task<IEnumerable<SubLetter>> GetAll();

        Task<SubLetter> GetById(int id);

        Task<SubLetter> AddAsync(SubLetterDto dto);


        Task<SubLetter> Update(int ser, SubLetterDto dto);


        Task<SubLetter> Delete(int id);

    }
}
