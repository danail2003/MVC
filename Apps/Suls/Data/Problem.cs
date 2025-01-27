﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Suls.Data
{
    public class Problem
    {
        public Problem()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Submissions = new HashSet<Submission>();
        }

        public string Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(300)]
        public int Points { get; set; }

        public ICollection<Submission> Submissions { get; set; }
    }
}
