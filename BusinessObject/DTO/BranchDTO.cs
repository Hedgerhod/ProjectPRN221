﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class BranchDTO
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; } 
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}