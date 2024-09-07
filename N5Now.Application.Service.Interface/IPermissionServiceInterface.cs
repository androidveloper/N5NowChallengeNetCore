using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N5Now.Application.DTO;
using N5Now.Domain.Entity;

namespace N5Now.Application.Service.Interface
{
    public interface IPermissionServiceInterface
    {
        Task RequestPermissionAsync(PermissionRequestDto request);
        Task ModifyPermissionAsync(int permissionId, string newPermissionName);
        Task<List<Permission>> GetPermissionsAsync();
    }
}
