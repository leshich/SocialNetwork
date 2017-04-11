﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Language
    {
        public int LanguageId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Profile> Profiles { get; set; }
    }
}
