﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Entities;
using EmployeeApp.Services;

namespace EmployeeApp
{
    internal class EmployeeManager
    {
        private readonly IStorageService _storageService;
        public EmployeeManager(IStorageService storageService)
        {
            _storageService = storageService;
        }
        public void Add()
        {
            var employee = new Employee();
            Console.WriteLine("FirstName:");
            employee.FirstName=Console.ReadLine();

            Console.WriteLine("LastName:");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Email:");
            employee.Email = Console.ReadLine();

            Console.WriteLine("Enter Employement Type: 1.FullTime: 2.Partime:");
            var employType=Console.ReadLine();
            employee.EmploymentType = employType;

            _storageService.Save(employee);
        }
        public void Remove()
        {
            Console.Write("Enter the employee id: ");
            var id = Console.ReadLine();
            _storageService.Delete(id);
        }

        public void Search()
        {
            Console.Write("Enter the name of the employee: ");
            var name = Console.ReadLine();

            var emplyee = _storageService.Search(name);
            if (emplyee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            Console.WriteLine(emplyee);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Delete Employee");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
