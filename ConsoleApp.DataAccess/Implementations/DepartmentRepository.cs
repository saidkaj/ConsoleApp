using System;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Interfaces;
using ConsoleApp.DataAccess.Contexts;

namespace ConsoleApp.DataAccess.Implementations
{
    public class DepartmentRepository : IRepository<Department>
    {
        public void Add(Department entity)
        {
            DbContext.Departments.Add(entity);
        }

        public void Delete(Department entity)
        {
            DbContext.Departments.Remove(entity);
        }

        public void Update(Department entity)
        {
            Department? department = DbContext.Departments.Find(emp => emp.DepartmentId == entity.DepartmentId);
            department.EmployeeLimit = entity.EmployeeLimit;
            department.DepartmentName = entity.DepartmentName;
        }

        public Department? GetById(int id)
        {
            return DbContext.Departments.Find(emp => emp.DepartmentId == id);
        }

        public List<Department> GetAll()
        {
            return DbContext.Departments;
        }

        public Department? GetByName(string name)
        {
            return DbContext.Departments.Find(emp => emp.DepartmentName == name);
        }

        public List<Department> GetAllByName(string name)
        {
            return DbContext.Departments.FindAll(emp => emp.DepartmentName == name); ;
        }
    }
}

