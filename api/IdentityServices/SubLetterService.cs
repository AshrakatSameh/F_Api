using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class SubLetterService : ISubLetterService
    {
        private readonly LetterDBContext _context;

        public SubLetterService(LetterDBContext context)
        {
            _context = context;

        }

        public async Task<SubLetter> Delete(int id)
        {
            var result = await _context.SubLetters.FirstOrDefaultAsync(e => e.Ser == id);
            if (result != null)
            {
                _context.SubLetters.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<SubLetter>> GetAll()
        {
            return await _context.SubLetters.ToListAsync();
        }


        public async Task<SubLetter> GetById(int id)
        {
            return await _context.SubLetters.FirstOrDefaultAsync(x => x.Ser == id);
        }

        public async Task<SubLetter> Post(SubLetter subletter)
        {
            var result = await _context.SubLetters.AddAsync(subletter);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<SubLetter> Put(SubLetter subletter)
        {
            var result = await _context.SubLetters.FirstOrDefaultAsync(e => e.Ser == subletter.Ser);

            if (result != null)
            {
                result.Ser = subletter.Ser;
                result.Nletter = subletter.Nletter;
                result.Noout1 = subletter.Noout1;
                result.Datecome = subletter.Datecome;
                result.Sidecome = subletter.Sidecome;
                result.Dateletter = subletter.Dateletter;
                result.Description = subletter.Description;
                result.Respons = subletter.Respons;
                result.Noprevletter = subletter.Noprevletter;
                result.Dateprevletter = subletter.Dateprevletter;
                result.Noout = subletter.Noout;
                result.Dateout = subletter.Dateout;
                result.Sideout = subletter.Sideout;
                result.Recevied = subletter.Recevied;
                result.Notes = subletter.Notes;
                result.Useradd = subletter.Useradd;
                result.Dateadd = subletter.Dateadd;
                result.Usermod = subletter.Usermod;
                result.Datemod = subletter.Datemod;
                result.DateMode = subletter.DateMode;

                await _context.SaveChangesAsync();
                return result;

            }

            return null;
        }
    }
}
