using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System;

namespace api.IdentityServices
{
    public class LetterExService : ILetterExService
    {
        private readonly LetterDBContext _context;

        public LetterExService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<LetterEx> Add(LettterexDto dto)
        {
            try
            {
                var letterEx = new LetterEx
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
                _context.AddAsync(letterEx);
                await _context.SaveChangesAsync();
                return letterEx;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create MainEx", ex);
            }
        }

        public async Task<LetterEx> Delete(int ser)
        {
            var letterEx = await _context.Letterices.FirstOrDefaultAsync(l=> l.Ser == ser);
            if (letterEx != null)
            {
                _context.Letterices.Remove(letterEx);
                await _context.SaveChangesAsync();
                return letterEx;
            }
            return null;
        }

        public async Task<IEnumerable<LetterEx>> GetAll()
        {
            return await _context.Letterices.ToListAsync();

        }

        public async Task<LetterEx> GetById(int ser)
        {
            var letterEx = await _context.Letterices.FirstOrDefaultAsync(i => i.Ser == ser);
            return (letterEx);
        }

      

        public async Task<LetterEx> Update(int ser, LettterexDto dto)
        {
           var letterEx = await _context.Letterices.FirstOrDefaultAsync(l=> l.Ser == ser);
            try
            {
                if (letterEx != null)
                {
                    letterEx.Noletter = dto.Noletter;
                    letterEx.Noout1 = dto.Noout1;
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
                return letterEx ;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update letterEx", ex);
            }
        }
    }
    }

