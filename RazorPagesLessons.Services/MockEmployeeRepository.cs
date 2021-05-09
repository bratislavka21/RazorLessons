using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesLessons.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 0, Name = "Eric", Email = "eric@example.com", Department = Dept.Management, PhotoPath = "avatar1.png"
                },
                new Employee()
                {
                    Id = 1, Name = "Kenny", Email = "kenny@example.com", Department = Dept.IT, PhotoPath = "avatar2.png"
                },
                new Employee()
                {
                    Id = 2, Name = "Kyle", Email = "kyle@example.com", Department = Dept.Accounting, PhotoPath = "avatar3.png"
                },
                new Employee()
                {
                    Id = 3, Name = "Stan", Email = "stan@example.com", Department = Dept.IT, PhotoPath = "avatar4.png"
                },
                new Employee()
                {
                    Id = 4, Name = "Santa", Email = "santa@example.com", Department = Dept.Management
                },
                new Employee()
                {
                    Id = 5, Name = "Butters", Email = "butters@example.com", Department = Dept.Management, PhotoPath = "avatar6.png"
                },
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
