using System;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Interfaces;
using ConsoleApp.DataAccess.Contexts;

namespace ConsoleApp.DataAccess.Implementations
{
    public class StudentRepository : IRepository<Employee>
    {
        public void Add(Employee entity)
        {
            DbContext.Employees.Add(entity);
        }

        public void Delete(Employee entity)
        {
            DbContext.Employees.Remove(entity);
        }

        public void Update(Employee entity)
        {
            Employee? emp = DbContext.Employees.Find(emp => emp.EmployeeId == entity.EmployeeId);
            emp.Name = entity.Name;
            emp.Surname = entity.Surname;
        }

        public Employee? Get(int id)
        {
            return DbContext.Employees.Find(emp => emp.EmployeeId == id);
        }

        public List<Employee> GetAll()
        {
            return DbContext.Employees;
        }

        public Employee? GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllByName(string name)
        {
            return DbContext.Employees.FindAll(emp => emp.Name == name);
        }
    }
}

