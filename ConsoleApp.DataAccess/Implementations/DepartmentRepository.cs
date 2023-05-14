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

        public Department? Get(int id)
        {
            return DbContext.Departments.Find(emp => emp.DepartmentId == id);
        }

        public List<Department> GetAll()
        {
            return DbContext.Departments;
        }

       
    }
}

