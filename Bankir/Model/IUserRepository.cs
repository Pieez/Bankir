﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bankir.Model
{
    internal interface IUserRepository
    {
        bool AutheticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetByUsername(string Username);
        IEnumerable <UserModel> GetByAll();
        //...
    }
}
