using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class MainExService : IMainEx
    {
        private readonly LetterDBContext _context;

        public MainExService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<MainEx> Add(MainExDto dto)
        {
            try
            {
                var main = new MainEx
                {
                    Noletter = dto.Noletter,
                    Datecome = dto.Datecome,
                    Code = dto.Code,
                    Sidecome = dto.Sidecome,
                    Dateletter = dto.Dateletter,
                    Description = dto.Description,
                    Respons = dto.Respons,
                    Datefolow = dto.Datefolow,
                    NoIn = dto.NoIn,
                    DateIn = dto.DateIn,
                    SideIn = dto.SideIn,
                    Recevied = dto.Recevied,
                    Noout1 = dto.Noout1,
                    Notes = dto.Notes,
                    Dateprevletter = dto.Dateprevletter,
                    Useradd = dto.Useradd,
                    Dateadd = dto.Dateadd,
                    Usermod = dto.Usermod,
                    Datemod = dto.Datemod,
                    DateMode = dto.DateMode

                };
                _context.Mainices.AddAsync(main);
                await _context.SaveChangesAsync();
                return main;
            }catch(Exception ex)
            {
                throw new Exception("Failed to create MainEx", ex);
            }
        }

        public async Task<MainEx> Delete(int id)
        {
            var mainEx =  _context.Mainices.FirstOrDefault(s => s.Id == id);
            if (mainEx != null)
            {
                _context.Mainices.Remove(mainEx);
                await _context.SaveChangesAsync();
                return mainEx;
            }
            return null;
        }

        public async Task<IEnumerable<MainEx>> GetAll()
        {
            var mainEx = await _context.Mainices.ToListAsync();
            return (mainEx);
        }

        public async Task<MainEx> GetById(int id)
        {
            return await _context.Mainices
               
                .FirstOrDefaultAsync(m => m.Id == id);
            
        }

        public async Task<MainEx> Update(int id ,MainExDto dto)
        {
            var main = await _context.Mainices.FirstOrDefaultAsync(m => m.Id == id);
            try
            {
                if(main != null)
                {
                    main.Noletter = dto.Noletter;
                    main.Code = dto.Code;
                    main.Datecome = dto.Datecome;
                    main.Sidecome = dto.Sidecome;
                    main.Dateletter = dto.Dateletter;
                    main.Description = dto.Description;
                    main.Respons = dto.Respons;
                    main.Datefolow = dto.Datefolow;
                    main.NoIn = dto.NoIn;
                    main.DateIn = dto.DateIn;
                    main.SideIn = dto.SideIn;
                    main.Recevied = dto.Recevied;
                    main.Notes = dto.Notes;
                    main.Dateprevletter = dto.Dateprevletter;
                    main.Useradd = dto.Useradd;
                    main.Dateadd = dto.Dateadd;

                    await _context.SaveChangesAsync();
                }
                return main;

            } catch(Exception ex)
            {
                throw new Exception("Failed to udatep MainEx", ex);
            }
        }
    }
}
