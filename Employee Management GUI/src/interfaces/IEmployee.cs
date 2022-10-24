namespace Employee_Management_GUI.src.interfaces
{
    internal interface IEmployee
    {
        public string? FirstName { get; }
        public string? LastName { get; }
        public string? Position { get; }
        public double? Salary { get; }
        public string? AssignedProject { get; }
        public string GetFullName();
        public string GetSalary();
    }
}
