﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
        //public virtual List<Employee> Employees { get; set; }
    }
}
