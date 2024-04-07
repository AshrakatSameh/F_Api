using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.IdentityServices
{
    public class EmpService : IEmpService
    {
        private readonly LetterDBContext _context;

        public EmpService(LetterDBContext context)
        {
            _context = context;
        }

        public async Task<Emp> Add(EmpDto dto)
        {
            try
            {
                var emp = new Emp
                {
                    Name = dto.Name
                };
                _context.Emps.AddAsync(emp);
                await _context.SaveChangesAsync();
                return emp;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create Employee", ex);
            }
        }

        public async Task<Emp> Delete(int ser)
        {
            var emp = _context.Emps.FirstOrDefault(s => s.Ser == ser);
            if (emp != null)
            {
                _context.Emps.Remove(emp);
                await _context.SaveChangesAsync();
                return emp;
            }
            return null;
        }

        public async Task<IEnumerable<Emp>> GetAll()
        {
            var emps = await _context.Emps.ToListAsync();
            return (emps);
        }

        public async Task<Emp> GetById(int ser)
        {
            return await _context.Emps.FirstOrDefaultAsync(m => m.Ser == ser);
        }

        public async Task<Emp> Update(int ser, EmpDto dto)
        {
            var emp = await _context.Emps.FirstOrDefaultAsync(m => m.Ser == ser);
            try
            {
                if (emp != null)
                {
                    

                    await _context.SaveChangesAsync();
                }
                return emp;

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update Employee", ex);
            }
        }
    }
    }
}
