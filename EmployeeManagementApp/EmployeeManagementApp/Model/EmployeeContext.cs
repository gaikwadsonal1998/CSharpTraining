﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Model
{
	class EmployeeContext :DbContext
	{
		public DbSet<Employee> Employees { get; set; }

	}
}
