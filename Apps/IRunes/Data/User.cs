﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IRunes.Data
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Albums = new HashSet<Album>();
        }

        public string Id { get; set; }

        [Required, MaxLength(10)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}