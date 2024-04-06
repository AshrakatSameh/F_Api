using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class MainLetterService : IMainLetterService
    {
        private readonly LetterDBContext _context;

        public MainLetterService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<MainLetter> Delete(int id)
        {
            var result = await _context.MainLetters
            .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _context.MainLetters.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }


        public async Task<IEnumerable<MainLetter>> GetAll()
        {
            return await _context.MainLetters.ToListAsync();
        }


        public async Task<MainLetter> GetById(int id)
        {
            return await _context.MainLetters.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<MainLetter> Post(MainLetter mainLetter)
        {
            var result = await _context.MainLetters.AddAsync(mainLetter);
            await _context.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<MainLetter> Put(MainLetter mainLetter)
        {
            var result = await _context.MainLetters.FirstOrDefaultAsync(e => e.Id == mainLetter.Id);

            if (result != null)
            {
                result.Id = mainLetter.Id;
                result.Noletter = mainLetter.Noletter;
                result.Datecome = mainLetter.Datecome;
                result.Code = mainLetter.Code;
                result.Sidecome = mainLetter.Sidecome;
                result.Dateletter = mainLetter.Dateletter;
                result.Description = mainLetter.Description;
                result.Respons = mainLetter.Respons;
                result.Dept = mainLetter.Dept;
                result.Datefolow = mainLetter.Datefolow;
                result.Noout = mainLetter.Noout;
                result.Dateout = mainLetter.Dateout;
                result.Sideout = mainLetter.Sideout;
                result.Recevied = mainLetter.Recevied;
                result.Notes = mainLetter.Notes;
                result.Noout1 = mainLetter.Noout1;
                result.Dateprevletter = mainLetter.Dateprevletter;
                result.Useradd = mainLetter.Useradd;
                result.Dateadd = mainLetter.Dateadd;
                result.Usermod = mainLetter.Usermod;
                result.Datemod = mainLetter.Datemod;
                result.DateMode = mainLetter.DateMode;

                await _context.SaveChangesAsync();
                return result;

            }

            return null;

        }
    }
}
