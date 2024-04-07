using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ILetterExService
    {
        Task<IEnumerable<LetterEx>> GetAll();
        Task<LetterEx> GetById(int ser);
        Task<LetterEx> Add(LettterexDto dto);
        Task<LetterEx> Delete(int ser);
        Task<LetterEx> Update(int ser, LettterexDto dto);
    
    }
}
