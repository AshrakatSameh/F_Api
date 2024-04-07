using api.Dtos;
using api.Interfaces;
using api.Models;

namespace api.IdentityServices
{
    public class SideService : ISideService
    {
        private readonly LetterDBContext _context;

        public SideService(LetterDBContext context)
        {
            _context = context;
        }

        public Task<Side> Add(SideDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<Side> Delete(int ser)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Side>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Side> GetById(int ser)
        {
            throw new NotImplementedException();
        }

        public Task<Side> Update(int ser, SideDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
