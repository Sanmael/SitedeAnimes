﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitedeAnimes.Services
{
    public interface ISeedUserRoleInitial
    {
        void SeedRoles();
        void SeedUsers();
    }
}
