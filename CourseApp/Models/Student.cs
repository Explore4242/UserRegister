﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        //[Required()]
        public string Name { get; set; }
        //[Required()]
        public string Email { get; set; }
        //[Required()]
        public string phone { get; set; }
        //[Required()]
        public bool? WillAtend { get; set; }
    }
}
   