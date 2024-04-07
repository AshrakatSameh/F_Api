using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class SubExService : ISubExService
    {
        private readonly LetterDBContext _context;

        public SubExService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<SubEx> AddAsync(SubExDto dto)
        {
            try
            {
                var subEx = new SubEx
                {
                    Noletter = dto.Noletter,
                    Noout1 = dto.Noout1,
                    Datecome = dto.Datecome,
                    Sidecome = dto.Sidecome,
                    Dateletter = dto.Dateletter,
                    Description = dto.Description,
                    Respons = dto.Respons,
                    Noprevletter = dto.Noprevletter,
                    Dateprevletter = dto.Dateprevletter,
                    Noout = dto.Noout,
                    Dateout = dto.Dateout,
                    Sideout = dto.Sideout,
                    Recevied = dto.Recevied,
                    Notes = dto.Notes,
                    Useradd = dto.Useradd,
                    Dateadd = dto.Dateadd,
                    Usermod = dto.Usermod,
                    Datemod = dto.Datemod,
                    DateMode = dto.DateMode

                };
                _context.AddAsync(subEx);
                await _context.SaveChangesAsync();
                return subEx;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create SubEx", ex);
            }
        }

        public async Task<SubEx> Delete(int ser)
        {
            var subEx = await _context.Subices.FirstOrDefaultAsync(s => s.Ser == ser);
            if (subEx != null)
            {
                _context.Subices.Remove(subEx);
                await _context.SaveChangesAsync();
                return subEx;
            }
            return null;
        }

        public async Task<IEnumerable<SubEx>> GetAll()
        {
            return await _context.Subices.ToListAsync();

        }

        public async Task<SubEx> GetById(int ser)
        {
            return await _context.Subices.FirstOrDefaultAsync(s => s.Ser == ser);
        }

        public async Task<SubEx> Update(int ser, SubExDto dto)
        {
            var subEx = await _context.Subices.FirstOrDefaultAsync(l => l.Ser == ser);
            try
            {
                if (subEx != null)
                {
                    subEx.Noletter = dto.Noletter;
                    subEx.Noout1 = dto.Noout1;
                    subEx.Datecome = dto.Datecome;
                    subEx.Sidecome = dto.Sidecome;
                    subEx.Dateletter = dto.Dateletter;
                    subEx.Description = dto.Description;
                    subEx.Respons = dto.Respons;
                    subEx.Noprevletter = dto.Noprevletter;
                    subEx.Dateprevletter = dto.Dateprevletter;
                    subEx.Noout = dto.Noout;
                    subEx.Dateout = dto.Dateout;
                    subEx.Sideout = dto.Sideout;
                    subEx.Recevied = dto.Recevied;
                    subEx.Notes = dto.Notes;
                    subEx.Useradd = dto.Useradd;
                    subEx.Dateadd = dto.Dateadd;
                    subEx.Usermod = dto.Usermod;
                    subEx.Datemod = dto.Datemod;
                    subEx.DateMode = dto.DateMode;

                    await _context.SaveChangesAsync();
                }
                return subEx;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update SubEx", ex);
            }
        }
    }
}
