using api.Dtos;
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

        public async Task<SubLetter> AddAsync(SubLetterDto dto)
        {
            try
            {
                var subLetter = new SubLetter
                {
                    Nletter = dto.Nletter,
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
                _context.AddAsync(subLetter);
                await _context.SaveChangesAsync();
                return subLetter;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create SubEx", ex);
            }

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

        public async Task<SubLetter> Update(int ser, SubLetterDto dto)
        {
            var subL = await _context.SubLetters.FirstOrDefaultAsync(l => l.Ser == ser);
            try
            {
                if (subL != null)
                {
                  subL.Nletter = dto.Nletter;
                  subL.Noout1 = dto.Noout1;
                  subL.Datecome = dto.Datecome;
                  subL.Sidecome = dto.Sidecome;
                  subL.Dateletter = dto.Dateletter;
                  subL.Description = dto.Description;
                  subL.Respons = dto.Respons;
                  subL.Noprevletter = dto.Noprevletter;
                  subL.Dateprevletter = dto.Dateprevletter;
                  subL.Noout = dto.Noout;
                  subL.Dateout = dto.Dateout;
                  subL.Sideout = dto.Sideout;
                  subL.Recevied = dto.Recevied;
                  subL.Notes = dto.Notes;
                  subL.Useradd = dto.Useradd;
                  subL.Dateadd = dto.Dateadd;
                  subL.Usermod = dto.Usermod;
                  subL.Datemod = dto.Datemod;
                    subL.DateMode = dto.DateMode;

                    await _context.SaveChangesAsync();
                }
                return subL;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update SubEx", ex);
            }

        }

        //public async Task<SubLetter> Post(SubLetterDto dto)
        //{

        //    try
        //    {
        //        var subLetter = new SubLetter
        //        {
        //            Nletter = dto.Nletter,
        //            Noout1 = dto.Noout1,
        //            Datecome = dto.Datecome,
        //            Sidecome = dto.Sidecome,
        //            Dateletter = dto.Dateletter,
        //            Description = dto.Description,
        //            Respons = dto.Respons,
        //            Noprevletter = dto.Noprevletter,
        //            Dateprevletter = dto.Dateprevletter,
        //            Noout = dto.Noout,
        //            Dateout = dto.Dateout,
        //            Sideout = dto.Sideout,
        //            Recevied = dto.Recevied,
        //            Notes = dto.Notes,
        //            Useradd = dto.Useradd,
        //            Dateadd = dto.Dateadd,
        //            Usermod = dto.Usermod,
        //            Datemod = dto.Datemod,
        //            DateMode = dto.DateMode

        //        };

        //        var result = await _context.SubLetters.AddAsync(subLetter);
        //        await _context.SaveChangesAsync();
        //        return result.Entity;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Failed to create SubEx", ex);
        //    }
        //}

        //    public async Task<SubLetter> Put(SubLetter subletter)
        //{
        //    var result = await _context.SubLetters.FirstOrDefaultAsync(e => e.Ser == subletter.Ser);

        //    if (result != null)
        //    {
        //        result.Ser = subletter.Ser;
        //        result.Nletter = subletter.Nletter;
        //        result.Noout1 = subletter.Noout1;
        //        result.Datecome = subletter.Datecome;
        //        result.Sidecome = subletter.Sidecome;
        //        result.Dateletter = subletter.Dateletter;
        //        result.Description = subletter.Description;
        //        result.Respons = subletter.Respons;
        //        result.Noprevletter = subletter.Noprevletter;
        //        result.Dateprevletter = subletter.Dateprevletter;
        //        result.Noout = subletter.Noout;
        //        result.Dateout = subletter.Dateout;
        //        result.Sideout = subletter.Sideout;
        //        result.Recevied = subletter.Recevied;
        //        result.Notes = subletter.Notes;
        //        result.Useradd = subletter.Useradd;
        //        result.Dateadd = subletter.Dateadd;
        //        result.Usermod = subletter.Usermod;
        //        result.Datemod = subletter.Datemod;
        //        result.DateMode = subletter.DateMode;

        //        await _context.SaveChangesAsync();
        //        return result;

        //    }

        //    return null;
        //}
    }
}
