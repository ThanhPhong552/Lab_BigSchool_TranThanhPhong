﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_BigSchool_TranThanhPhong.Models
{
    public class Category
    {
            public byte Id { get; set; }
            [Required]
            [StringLength(255)]
            public string Name { get; set; }
    }
}