using api.Models;

namespace api.Interfaces
{
    public interface IMainLetterService
    {
        Task<IEnumerable<MainLetter>> GetAll();

        Task<MainLetter> GetById(int id);

        Task<MainLetter> Post(MainLetter mainLetter);


        Task<MainLetter> Put(MainLetter mainLetter);


        Task<MainLetter> Delete(int id);
    }
}
