﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }
        [Required]
        public string ResultText { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
