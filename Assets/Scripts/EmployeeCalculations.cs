using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts {
    public class EmployeeCalculations {

        private List<Employee> employees;
        private Dictionary<string, Dictionary<Seniority, int>> salaries;
        private Dictionary<string, Dictionary<Seniority, float>> increments;

        public EmployeeCalculations() {
            IDataFeed dataFeed = new JsonDataFeed();
            employees = new List<Employee>(dataFeed.GetEmployees());
            salaries = dataFeed.GetSalaries();
            increments = dataFeed.GetSalaryIncrements();
        }

        public List<Employee> GetEmployeesByArea(string area) {
            List<Employee> filteredEmployees = employees.FindAll((Employee e) => { return e.area.ToLower().Equals(area.ToLower()); });
            filteredEmployees.Sort((Employee a, Employee b) => { return a.seniority.CompareTo(b.seniority); });
            return filteredEmployees;
        }

        public IEnumerable<string> GetAreas() {
            return employees.Select(e => e.area).Distinct();
        }

        public int GetEmployeeSalary(Employee employee) {
            return salaries[employee.area][employee.seniority];
        }

        public float GetEmployeeIncrement(Employee employee) {
            return increments[employee.area][employee.seniority];
        }

        public float GetEmployeeSalaryIncremented(Employee employee) {
            return GetEmployeeSalary(employee) + GetEmployeeIncrement(employee) / 100 * GetEmployeeSalary(employee);
        }
    }
}