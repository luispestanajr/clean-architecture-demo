﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;

namespace CleanArchitecture.Specification.Common
{
    public class DatabaseLookup
    {
        private readonly IDatabaseContext _database;

        public DatabaseLookup(IDatabaseContext database)
        {
            _database = database;
        }

        public int GetCustomerId(string name)
        {
            return _database.Customers
                .Single(p => p.Name == name).Id;
        }

        public int GetEmployeeId(string name)
        {
            return _database.Employees
                .Single(p => p.Name == name).Id;
        }

        public int GetProductIdByName(string name)
        {
            return _database.Products
                .Single(p => p.Name == name).Id;
        }
    }
}
