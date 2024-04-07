using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace api.IdentityServices
{
    public class LoginService : ILoginService
    {
        private readonly LetterDBContext _context;

        public LoginService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<Login> Add(LoginDto dto)
        {
            try
            {
                var log = new Login
                {

                    Name = dto.Name,
                    Pass = dto.Pass,
                    Role = dto.Role
                };
                _context.AddAsync(log);
                await _context.SaveChangesAsync();
                return log;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create Login", ex);
            }
        }

        public async Task<Login> Delete(int id)
        {
            var result = await _context.Logins
          .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _context.Logins.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Login>> GetAll()
        {
            return await _context.Logins.ToListAsync();
        }

        public async Task<Login> GetById(int id)
        {
            return await _context.Logins.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Login> Update(int id, LoginDto dto)
        {
            var log = await _context.Logins.FirstOrDefaultAsync(l => l.Id == id);
            try
            {
                if (log != null)
                {
                    log.Name = dto.Name;
                    log.Pass = dto.Pass;
                    log.Role = dto.Role;



                    await _context.SaveChangesAsync();
                }
                return log;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update Login", ex);
            }
        }
    }
}
