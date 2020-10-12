﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FPTTraining0.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Course Name")]
        public string Name { get; set; }
    }
}