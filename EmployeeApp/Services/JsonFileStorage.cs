using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Entities;

namespace EmployeeApp.Services
{
     class JsonFileStorage:IStorageService
    {
        private readonly string _storageDirectory;
        public JsonFileStorage()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentPath, "EmployeeApp", "JsonData");
            Directory.CreateDirectory(_storageDirectory);
        }
        public void Delete(string id)
        {
            var filePath = Path.Combine(_storageDirectory, $"{id}.json");
            File.Delete(filePath);
        }

        public Employee GetById(string id)
        {
            return default;
        }

        public void Save(Employee employee)
        {
            var jsonText = JsonConvert.SerializeObject(employee);
            var filePath = Path.Combine(_storageDirectory, $"{employee.Id}.json");
            File.WriteAllText(filePath, jsonText);
        }

        public Employee Search(string name)
        {
            var files = Directory.GetFiles(_storageDirectory);
            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                Employee employee = JsonConvert.DeserializeObject<Employee>(fileContentJson);

                var employeeName = employee.FullName.ToLowerInvariant();
                var nameToSearch = name.ToLowerInvariant();

                if (employeeName.Contains(nameToSearch))
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
