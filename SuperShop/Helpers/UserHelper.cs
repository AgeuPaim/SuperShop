﻿using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> _userManager;

        public UserHelper(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _userManager.FindByNameAsync(email);
        }

        internal  Task<User> GetUserByEmailAsync(string v)
        {
            throw new NotImplementedException();
        }
    }
}
