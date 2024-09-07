using N5Now.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N5Now.Domain.Interface
{
    public interface IPermissionTypeDomain
    {
        Task<PermissionType> GetByIdAsync(int id);
        Task<List<PermissionType>> GetAllAsync();

    }
}
