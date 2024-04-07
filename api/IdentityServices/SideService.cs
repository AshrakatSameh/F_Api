using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class SideService : ISideService
    {
        private readonly LetterDBContext _context;

        public SideService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<Side> Add(SideDto dto)
        {
            try
            {
                var side = new Side
                {
                    Side1 = dto.Side1
                };
                _context.Sides.AddAsync(side);
                await _context.SaveChangesAsync();
                return side;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create Side", ex);
            }
        }

        public async Task<Side> Delete(int ser)
        {
            var side = _context.Sides.FirstOrDefault(s => s.Ser == ser);
            if (side != null)
            {
                _context.Sides.Remove(side);
                await _context.SaveChangesAsync();
                return side;
            }
            return null;
        }

        public async Task<IEnumerable<Side>> GetAll()
        {
            var side = await _context.Sides.ToListAsync();
            return (side);
        }

        public async Task<Side> GetById(int ser)
        {
            return await _context.Sides.FirstOrDefaultAsync(m => m.Ser == ser);
        }

        public async Task<Side> Update(int ser, SideDto dto)
        {
            var side = await _context.Sides.FirstOrDefaultAsync(m => m.Ser == ser);
            try
            {
                if (side != null)
                {


                    await _context.SaveChangesAsync();
                }
                return side;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update Side", ex);
            }
        }
    }
}
