﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab8_WebAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
