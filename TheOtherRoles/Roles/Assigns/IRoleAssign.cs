using System;
using System.Collections.Generic;

namespace TheOtherRoles.Roles.Assigns;

public interface IRoleAssign : IDisposable
{
    public RoleBase Assign();

    public IRoleAssign SetAssign(IEnumerable<RoleBase> bases);
}