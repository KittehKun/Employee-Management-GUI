namespace Employee_Management_GUI.src.classes
{
    internal class EmployeeDatabase
    {
        private List<Employee> employees;

        public EmployeeDatabase()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee RetrieveEmployee(int index)
        {
            return employees[index];
        }

        public int GetCount()
        {
            return employees.Count;
        }
    }
}
