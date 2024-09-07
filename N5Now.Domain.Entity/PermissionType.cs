using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Now.Domain.Entity
{
    public class PermissionType
    {
        public int Id { get; private set; }
        public string Description { get; private set; }

        public PermissionType(string description)
        {
            Description = description;
        }
    }
}
