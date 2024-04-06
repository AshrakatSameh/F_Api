using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class ExLetterService : IExLetterService
    {
        private readonly LetterDBContext _context;

        public ExLetterService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<Exletter> Delete(int id)
        {
            var result = await _context.Exletters
           .FirstOrDefaultAsync(e => e.Ser == id);
            if (result != null)
            {
                _context.Exletters.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }



        public async Task<IEnumerable<Exletter>> GetAll()
        {
            return await _context.Exletters.ToListAsync();
        }



        public async Task<Exletter> GetById(int id)
        {
            return await _context.Exletters.FirstOrDefaultAsync(x => x.Ser == id);

        }

        public  async Task<Exletter> Post(Exletter exLetter)
        {
            var result = await _context.Exletters.AddAsync(exLetter);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Exletter> Put(Exletter exLetter)
        {
            var result = await _context.Exletters.FirstOrDefaultAsync(e => e.Ser == exLetter.Ser);

            if (result != null)
            {
                result.Ser = exLetter.Ser;
                result.Noout2 = exLetter.Noout2;
                result.Noletter = exLetter.Noletter;
                result.Datecome = exLetter.Datecome;
                result.Sidecome = exLetter.Sidecome;
                result.Dateletter = exLetter.Dateletter;
                result.Description = exLetter.Description;
                result.Respons = exLetter.Respons;
                result.Noprevletter = exLetter.Noprevletter;
                result.Dateprevletter = exLetter.Dateprevletter;
                result.Noout = exLetter.Noout;
                result.Dateout = exLetter.Dateout;
                result.Sideout = exLetter.Sideout;
                result.Recevied = exLetter.Recevied;
                result.Notes = exLetter.Notes;
                result.Useradd = exLetter.Useradd;
                result.Dateadd = exLetter.Dateadd;
                result.Usermod = exLetter.Usermod;
                result.Datemod = exLetter.Datemod;
                result.DateMode = exLetter.DateMode;

                await _context.SaveChangesAsync();
                return result;

            }

            return null;
        }
    }
}
