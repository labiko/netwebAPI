using netwebAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace netwebAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public StudentRepository(StudentAdminContext context)
        {
            this._context = context;
        }
        public async Task<List<DataModels.Student>> GetStudentsAsync()
        {
            return await _context.Sutudent.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }


    }
}
