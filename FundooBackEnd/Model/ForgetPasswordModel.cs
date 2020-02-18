﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class ForgetPasswordModel
    {
        [EmailAddress]
        [Required]
        public string Email
        {
            get;
            set;
        }
    }
}
