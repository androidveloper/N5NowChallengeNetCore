using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Now.Domain.Entity
{
    public class Permission
    {
        public int Id { get; private set; }
        public string PermissionName { get; private set; }
        public PermissionType PermissionType { get; private set; }

        public Permission(string permissionName, PermissionType permissionType)
        {
            PermissionName = permissionName;
            PermissionType = permissionType;
        }

        public void ChangePermissionName(string newName)
        {
            PermissionName = newName;
        }
    }
}
