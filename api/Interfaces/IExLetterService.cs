using api.Models;

namespace api.Interfaces
{
    public interface IExLetterService
    {
        Task<IEnumerable<Exletter>> GetAll();

        Task<Exletter> GetById(int id);

        Task<Exletter> Post(Exletter exLetter);


        Task<Exletter> Put(Exletter exLetter);


        Task<Exletter> Delete(int id);
    }
}
