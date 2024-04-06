using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.IdentityServices
{
    public class DeptService : IDeptService
    {
        private readonly LetterDBContext _context;

        public DeptService(LetterDBContext context)
        {
            _context = context;
        }

      

        public async Task<Dept> Delete(int id)
        {
            var result = await _context.Depts
            .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _context.Depts.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Dept>> GetAll()
        {
            return await _context.Depts.ToListAsync();
        }

        public async Task<Dept> GetById(int id)
        {
            return await _context.Depts.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<Dept> Post(Dept dept)
        {
            var result =  await _context.Depts.AddAsync(dept);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

 
        

        public async Task<Dept> Put(Dept dept)
        {
            var result = await _context.Depts.FirstOrDefaultAsync(e => e.Id == dept.Id);

            if (result != null)
            {
                result.Id = dept.Id;
                result.DeptName = dept.DeptName;

                await _context.SaveChangesAsync();
                return result;

            }

            return null;

        }

    }
}
