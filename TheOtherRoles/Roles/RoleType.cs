using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheOtherRoles.Roles;

public class RoleType
{
    private static readonly List<RoleType> _AllRoleInfo = [];

    public RoleType()
    {
        _AllRoleInfo.Add(this);
    }

    public static IReadOnlyList<RoleType> AllRoleInfo => _AllRoleInfo;

    public Color Color { get; set; }
    public string Name { get; set; }
    public RoleId RoleId { get; set; }
    public RoleTeam RoleTeam { get; set; }
}
