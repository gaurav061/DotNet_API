﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Spliwise.Dtos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,1000)]
        public decimal Price { get; set; }
    }
}
