using api.Dtos;
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

        public async Task<Exletter> Add(ExLetterDto dto)
        {
            try
            {
                var ExL = new Exletter
                {
                    Noout2 = dto.Noout2,
                    Noletter = dto.Noletter,
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
                _context.AddAsync(ExL);
                await _context.SaveChangesAsync();
                return ExL;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create MainEx", ex);
            }
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

        public async Task<Exletter> Update(int ser, ExLetterDto dto)
        {
            var letterEx = await _context.Exletters.FirstOrDefaultAsync(l => l.Ser == ser);
            try
            {
                if (letterEx != null)
                {
                    letterEx.Noletter = dto.Noletter;
                    letterEx.Noout2 = dto.Noout2;
                    letterEx.Datecome = dto.Datecome;
                    letterEx.Sidecome = dto.Sidecome;
                    letterEx.Dateletter = dto.Dateletter;
                    letterEx.Description = dto.Description;
                    letterEx.Respons = dto.Respons;
                    letterEx.Noprevletter = dto.Noprevletter;
                    letterEx.Dateprevletter = dto.Dateprevletter;
                    letterEx.Noout = dto.Noout;
                    letterEx.Dateout = dto.Dateout;
                    letterEx.Sideout = dto.Sideout;
                    letterEx.Recevied = dto.Recevied;
                    letterEx.Notes = dto.Notes;
                    letterEx.Useradd = dto.Useradd;
                    letterEx.Dateadd = dto.Dateadd;
                    letterEx.Usermod = dto.Usermod;
                    letterEx.Datemod = dto.Datemod;
                    letterEx.DateMode = dto.DateMode;

                    await _context.SaveChangesAsync();
                }
                return letterEx;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update letterEx", ex);
            }
        }


        //public  async Task<Exletter> Post(Exletter exLetter)
        //{
        //    var result = await _context.Exletters.AddAsync(exLetter);
        //    await _context.SaveChangesAsync();
        //    return result.Entity;
        //}

        //public async Task<Exletter> Put(Exletter exLetter)
        //{
        //    var result = await _context.Exletters.FirstOrDefaultAsync(e => e.Ser == exLetter.Ser);

        //    if (result != null)
        //    {
        //        result.Ser = exLetter.Ser;
        //        result.Noout2 = exLetter.Noout2;
        //        result.Noletter = exLetter.Noletter;
        //        result.Datecome = exLetter.Datecome;
        //        result.Sidecome = exLetter.Sidecome;
        //        result.Dateletter = exLetter.Dateletter;
        //        result.Description = exLetter.Description;
        //        result.Respons = exLetter.Respons;
        //        result.Noprevletter = exLetter.Noprevletter;
        //        result.Dateprevletter = exLetter.Dateprevletter;
        //        result.Noout = exLetter.Noout;
        //        result.Dateout = exLetter.Dateout;
        //        result.Sideout = exLetter.Sideout;
        //        result.Recevied = exLetter.Recevied;
        //        result.Notes = exLetter.Notes;
        //        result.Useradd = exLetter.Useradd;
        //        result.Dateadd = exLetter.Dateadd;
        //        result.Usermod = exLetter.Usermod;
        //        result.Datemod = exLetter.Datemod;
        //        result.DateMode = exLetter.DateMode;

        //        await _context.SaveChangesAsync();
        //        return result;

        //    }

        //    return null;
        //}
    }
}
