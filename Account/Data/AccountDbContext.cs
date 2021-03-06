﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Aiursoft.Account.Models;

namespace Aiursoft.Account.Data
{
    public class AccountDbContext : IdentityDbContext<AccountUser>
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options)
            : base(options)
        {

        }
    }
}
