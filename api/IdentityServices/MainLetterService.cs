using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System;

namespace api.IdentityServices
{
    public class MainLetterService : IMainLetterService
    {
        private readonly LetterDBContext _context;

        public MainLetterService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<MainLetter> Add(MainLetterDto dto)
        {
            try
            {
                var main = new MainLetter
                {
                    Noletter = dto.Noletter,
                    Datecome = dto.Datecome,
                    Code = dto.Code,
                    Sidecome = dto.Sidecome,
                    Dateletter = dto.Dateletter,
                    Description = dto.Description,
                    Respons = dto.Respons,
                    Dept= dto.Dept,
                    Datefolow = dto.Datefolow,
                    Noout = dto.Noout,
                    Dateout = dto.Dateout,
                    Sideout = dto.Sideout,
                    Noout1 = dto.Noout1,
                    Recevied = dto.Recevied,
                    Notes = dto.Notes,
                    Dateprevletter = dto.Dateprevletter,
                    Useradd = dto.Useradd,
                    Dateadd = dto.Dateadd,
                    Usermod = dto.Usermod,
                    Datemod = dto.Datemod,
                    DateMode = dto.DateMode

                };
                _context.MainLetters.AddAsync(main);
                await _context.SaveChangesAsync();
                return main;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create MainEx", ex);
            }
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

        public async Task<MainLetter> Update(int id, MainLetterDto dto)
        {
            var main = await _context.MainLetters.FirstOrDefaultAsync(m => m.Id == id);
            try
            {
                if (main != null)
                {
                    main.Noletter = dto.Noletter;
                   main.Datecome = dto.Datecome;
                   main.Code = dto.Code;
                   main.Sidecome = dto.Sidecome;
                   main.Dateletter = dto.Dateletter;
                   main.Description = dto.Description;
                   main.Respons = dto.Respons;
                   main.Dept = dto.Dept;
                   main.Datefolow = dto.Datefolow;
                   main.Noout = dto.Noout;
                   main.Dateout = dto.Dateout;
                   main.Sideout = dto.Sideout;
                   main.Noout1 = dto.Noout1;
                   main.Recevied = dto.Recevied;
                   main.Notes = dto.Notes;
                   main.Dateprevletter = dto.Dateprevletter;
                   main.Useradd = dto.Useradd;
                   main.Dateadd = dto.Dateadd;
                   main.Usermod = dto.Usermod;
                   main.Datemod = dto.Datemod;
                   main.DateMode = dto.DateMode;
                    await _context.SaveChangesAsync();
                }
                return main;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to udatep MainLetter", ex);
            }
        }


        //public async Task<MainLetter> Post(MainLetter mainLetter)
        //{
        //    var result = await _context.MainLetters.AddAsync(mainLetter);
        //    await _context.SaveChangesAsync();
        //    return result.Entity;
        //}


        //public async Task<MainLetter> Put(MainLetter mainLetter)
        //{
        //    var result = await _context.MainLetters.FirstOrDefaultAsync(e => e.Id == mainLetter.Id);

        //    if (result != null)
        //    {
        //        result.Id = mainLetter.Id;
        //        result.Noletter = mainLetter.Noletter;
        //        result.Datecome = mainLetter.Datecome;
        //        result.Code = mainLetter.Code;
        //        result.Sidecome = mainLetter.Sidecome;
        //        result.Dateletter = mainLetter.Dateletter;
        //        result.Description = mainLetter.Description;
        //        result.Respons = mainLetter.Respons;
        //        result.Dept = mainLetter.Dept;
        //        result.Datefolow = mainLetter.Datefolow;
        //        result.Noout = mainLetter.Noout;
        //        result.Dateout = mainLetter.Dateout;
        //        result.Sideout = mainLetter.Sideout;
        //        result.Recevied = mainLetter.Recevied;
        //        result.Notes = mainLetter.Notes;
        //        result.Noout1 = mainLetter.Noout1;
        //        result.Dateprevletter = mainLetter.Dateprevletter;
        //        result.Useradd = mainLetter.Useradd;
        //        result.Dateadd = mainLetter.Dateadd;
        //        result.Usermod = mainLetter.Usermod;
        //        result.Datemod = mainLetter.Datemod;
        //        result.DateMode = mainLetter.DateMode;

        //        await _context.SaveChangesAsync();
        //        return result;

        //    }

        //    return null;

        //}
    }
}
