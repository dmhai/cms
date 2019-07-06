﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SS.CMS.Models;

namespace SS.CMS.Repositories
{
    public partial interface IUserMenuRepository
    {
        Task<List<UserMenuInfo>> GetAllUserMenusAsync();

        Task<UserMenuInfo> GetUserMenuInfoAsync(int menuId);
    }
}
