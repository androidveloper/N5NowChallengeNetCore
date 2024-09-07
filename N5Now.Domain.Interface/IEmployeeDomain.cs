using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N5Now.Domain.Entity;

namespace N5Now.Domain.Interface
{
    public interface IEmployeeDomain
    {

        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task<List<Employee>> GetAllAsync();
    }
}

