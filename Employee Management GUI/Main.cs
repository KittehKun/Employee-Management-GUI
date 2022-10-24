using Employee_Management_GUI.src.classes;
using System.Diagnostics;
using System.Xml;

namespace Employee_Management_GUI
{
    public partial class Main : Form
    {
        EmployeeDatabase employees;

        //Constructor
        public Main()
        {
            InitializeComponent();
            listEmployees.Items.Clear();
            this.employees = new EmployeeDatabase();
            LoadDatabase(this.employees);
            FillListView();
            GenerateFakeMetrics();
        }

        //Methods
        private void LoadDatabase(EmployeeDatabase employees)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                //Load XML Document
                doc.Load("src/databases/Employees.xml"); //File was set to copy to output folder in Visual Studio

                //Parse data into Employee object
                foreach (XmlNode node in doc.ChildNodes[1]!)
                {
                    string fName, lName, position, project;
                    double salary;
                    fName = node.Attributes![0].Value; //fName
                    lName = node.Attributes[1].Value; //lName
                    position = node.ChildNodes[0]!.InnerText; //Position child node
                    salary = double.Parse(node.ChildNodes[1]!.InnerText); //Salary child node
                    project = node.ChildNodes[2]!.InnerText; //Project child node

                    employees.AddEmployee(new Employee(fName, lName, position, salary, project));
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                Environment.Exit(404);
            }
        }

        private void FillListView()
        {
            Debug.WriteLine($"There are {employees.GetCount()} employees in the list.");
            for (int i = 0; i < employees.GetCount(); i++)
            {
                ListViewItem parentItem = new ListViewItem();
                ListViewItem.ListViewSubItem position = new ListViewItem.ListViewSubItem(); //Position
                position.Text = employees.RetrieveEmployee(i).Position;
                ListViewItem.ListViewSubItem salary = new ListViewItem.ListViewSubItem(); //Salary
                salary.Text = employees.RetrieveEmployee(i).GetSalary();
                ListViewItem.ListViewSubItem project = new ListViewItem.ListViewSubItem(); //Project
                project.Text = employees.RetrieveEmployee(i).AssignedProject;

                parentItem.Text = employees.RetrieveEmployee(i).GetFullName();
                parentItem.SubItems.Add(position);
                parentItem.SubItems.Add(salary);
                parentItem.SubItems.Add(project);

                listEmployees.Items.Add(parentItem);

                Debug.WriteLine("Employee was added to the list.");

                colHeaderProject.Width = -2; //Auto Resize last column if there is any text overflowing the control
            }
        }

        private void listEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
                e.Item.Focused = false;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this); //Opens new form
            addEmployee.ShowDialog();
            ListViewItem parentItem = new ListViewItem();
            ListViewItem.ListViewSubItem position = new ListViewItem.ListViewSubItem(); //Position
            position.Text = employees.RetrieveEmployee(employees.GetCount() - 1).Position;
            ListViewItem.ListViewSubItem salary = new ListViewItem.ListViewSubItem(); //Salary
            salary.Text = employees.RetrieveEmployee(employees.GetCount() - 1).GetSalary();
            ListViewItem.ListViewSubItem project = new ListViewItem.ListViewSubItem(); //Project
            project.Text = employees.RetrieveEmployee(employees.GetCount() - 1).AssignedProject;

            parentItem.Text = employees.RetrieveEmployee(employees.GetCount() - 1).GetFullName();
            parentItem.SubItems.Add(position);
            parentItem.SubItems.Add(salary);
            parentItem.SubItems.Add(project);

            listEmployees.Items.Add(parentItem);

            Debug.WriteLine("Employee was added to the list.");
        }

        public void AddEmployee(string fName, string lName, string position, double salary, string project)
        {
            this.employees.AddEmployee(new Employee(fName, lName, position, salary, project));
            for (int i = 0; i < this.employees.GetCount(); i++)
            {
                Debug.WriteLine(this.employees.RetrieveEmployee(i).GetFullName());
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this); //Opens new form
            addEmployee.ShowDialog();
            ListViewItem parentItem = new ListViewItem();
            ListViewItem.ListViewSubItem position = new ListViewItem.ListViewSubItem(); //Position
            position.Text = employees.RetrieveEmployee(employees.GetCount() - 1).Position;
            ListViewItem.ListViewSubItem salary = new ListViewItem.ListViewSubItem(); //Salary
            salary.Text = employees.RetrieveEmployee(employees.GetCount() - 1).GetSalary();
            ListViewItem.ListViewSubItem project = new ListViewItem.ListViewSubItem(); //Project
            project.Text = employees.RetrieveEmployee(employees.GetCount() - 1).AssignedProject;

            parentItem.Text = employees.RetrieveEmployee(employees.GetCount() - 1).GetFullName();
            parentItem.SubItems.Add(position);
            parentItem.SubItems.Add(salary);
            parentItem.SubItems.Add(project);

            listEmployees.Items.Add(parentItem);

            Debug.WriteLine("Employee was added to the list.");
        }

        private void GenerateFakeMetrics()
        {
            //Generate random profit numbers
            Random random = new();
            int randomProfit = random.Next(-100000, 100000);
            double fakeProfit = randomProfit;
            if (fakeProfit < 0)
            {
                grossProfitLoss.Text = String.Format("{0:C2}", fakeProfit);
                grossProfitLoss.ForeColor = Color.Red;
            }
            else
            {
                grossProfitLoss.Text = String.Format("{0:C2}", fakeProfit);
                grossProfitLoss.ForeColor = Color.Green;
            }

            //Pick a random employee for MVP
            int pickedEmployee = random.Next(0, this.employees.GetCount());
            employeeMVP.Text = this.employees.RetrieveEmployee(pickedEmployee).GetFullName();

            //Generate random revenue number
            int randomRevenue = random.Next(0, 100000);
            double fakeRevenue = randomRevenue;
            estimatedRevenue.Text = String.Format("{0:C2}", fakeRevenue);
            estimatedRevenue.ForeColor = Color.Green;
        }
    }
}