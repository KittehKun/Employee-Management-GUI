using Employee_Management_GUI.src.interfaces;

namespace Employee_Management_GUI.src.classes
{
    internal class Employee : IEmployee
    {
        //Interface
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Position { get; private set; }
        public double? Salary { get; private set; }
        public string? AssignedProject { get; private set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetSalary()
        {
            return String.Format("{0:C2}", Salary.ToString());
        }

        //Constructor
        public Employee(string fName, string lName, string position, double salary, string project)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Position = position;
            this.Salary = salary;
            this.AssignedProject = project;
        }
    }
}
