﻿using SharedTrip.Data;
using SharedTrip.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SharedTrip.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;

        public UsersService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public string GetUserId(LoginInputModel model)
        {
            return this.db.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == Hash(model.Password)).Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return this.db.Users.Any(x => x.Email == email);
        }

        public bool IsUsernameAndPasswordMatch(LoginInputModel model)
        {
            return this.db.Users.Any(x => x.Username == model.Username && x.Password == Hash(model.Password));
        }

        public bool IsUsernameAvailable(string username)
        {
            return this.db.Users.Any(x => x.Username == username);
        }

        public void Register(RegisterInputModel model)
        {
            this.db.Users.Add(new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = Hash(model.Password),
            });

            this.db.SaveChanges();
        }

        private string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
