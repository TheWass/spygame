﻿using spygame.Enums;
using System.Collections.Generic;

namespace spygame.Models
{
    public class RoleModel
    {
        public Roles Role;
        public Teams Team;
        public string playerName;
        public List<RoleModel> otherPlayerRoleInfo;
    }
}