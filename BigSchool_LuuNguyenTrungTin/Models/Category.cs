﻿using System.ComponentModel.DataAnnotations;

namespace BigSchool_LuuNguyenTrungTin.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}