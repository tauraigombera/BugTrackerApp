﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerApp.Data.Static
{
    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string ProjectManager = "Project Manager";
        public const string Programmer = "Programmer";
        public const string User = "User";
    }
}
