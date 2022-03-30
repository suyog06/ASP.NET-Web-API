﻿using ParkyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUserUnique(string userName);
        User Authenticate(string userName, string password);
        User Register(string userName, string password);
    }
}
