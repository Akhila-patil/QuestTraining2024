using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Entities;

namespace EmployeeApp.Services
{
    internal interface IStorageService
    {
        void Save(Employee employee);

        Employee GetById(string id);

        void Delete(string id);

        Employee Search(string name);
    }
}
