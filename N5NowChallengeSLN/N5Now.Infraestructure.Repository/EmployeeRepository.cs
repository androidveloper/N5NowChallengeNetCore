using Microsoft.EntityFrameworkCore;
using N5Now.Domain.Entity;
using N5Now.Domain.Interface;
using N5Now.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N5Now.Infraestructure.Repository
{
    public class EmployeeRepository : IEmployeeDomain
    {

        private readonly PermissionDbContext _context;

        public EmployeeRepository(PermissionDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.Include(e => e.Permissions).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.Include(e => e.Permissions).ToListAsync();
        }
    }
}
