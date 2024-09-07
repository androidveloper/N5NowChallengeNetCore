using N5Now.Application.Service.Interface;
using N5Now.Domain.Entity;
using N5Now.Domain.Interface;
using N5Now.Application.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace N5Now.Application.Service
{
    public class PermissionService : IPermissionServiceInterface
    {
        private readonly IEmployeeDomain _employeeRepository;
        private readonly IPermissionTypeDomain _permissionTypeRepository;

        public PermissionService(IEmployeeDomain employeeRepository, IPermissionTypeDomain permissionTypeRepository)
        {
            _employeeRepository = employeeRepository;
            _permissionTypeRepository = permissionTypeRepository;
        }

        public async Task RequestPermissionAsync(PermissionRequestDto request)
        {
            var employee = await _employeeRepository.GetByIdAsync(request.EmployeeId);
            var permissionType = await _permissionTypeRepository.GetByIdAsync(request.PermissionTypeId);

            if (employee == null || permissionType == null)
                throw new Exception("Invalid employee or permission type");

            var permission = new Permission("New Permission", permissionType);
            employee.AddPermission(permission);

            await _employeeRepository.UpdateAsync(employee);
        }

        public async Task ModifyPermissionAsync(int permissionId, string newPermissionName)
        {
            var employee = await _employeeRepository.GetByIdAsync(permissionId);
            if (employee == null) throw new Exception("Permission not found");

            var permission = employee.Permissions.FirstOrDefault(p => p.Id == permissionId);
            permission?.ChangePermissionName(newPermissionName);

            await _employeeRepository.UpdateAsync(employee);
        }

        public async Task<List<Permission>> GetPermissionsAsync()
        {
            // Example logic, fetching all employees' permissions
            var employees = await _employeeRepository.GetAllAsync();
            return employees.SelectMany(e => e.Permissions).ToList();
        }
    }
}
