﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finals3.Model
{
    public class Expense
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }
    }
}
