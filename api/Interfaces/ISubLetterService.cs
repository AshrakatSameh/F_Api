using api.Models;

namespace api.Interfaces
{
    public interface ISubLetterService
    {
        Task<IEnumerable<SubLetter>> GetAll();

        Task<SubLetter> GetById(int id);

        Task<SubLetter> Post(SubLetter subletter);


        Task<SubLetter> Put(SubLetter subletter);


        Task<SubLetter> Delete(int id);
    }
}
