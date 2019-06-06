﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Customer (string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}