using System.Security;

namespace N5Now.Domain.Entity
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private readonly List<Permission> _permissions;

        public IReadOnlyCollection<Permission> Permissions => _permissions.AsReadOnly();

        public Employee(string name)
        {
            Name = name;
            _permissions = new List<Permission>();
        }

        public void AddPermission(Permission permission)
        {
            _permissions.Add(permission);
        }
    }
}
