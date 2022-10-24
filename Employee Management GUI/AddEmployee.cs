namespace Employee_Management_GUI
{
    public partial class AddEmployee : Form
    {
        private Main mainForm;

        public AddEmployee(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Validates that all textboxes are all valid before adding to database
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //There is a more efficent way but for now this works
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtLastName.Text) && !String.IsNullOrEmpty(txtPosition.Text) && !String.IsNullOrEmpty(txtProject.Text) && !String.IsNullOrEmpty(txtSalary.Text))
            {
                string fName, lName, position, project;
                double salary;

                fName = txtName.Text;
                lName = txtLastName.Text;
                position = txtPosition.Text;
                project = txtProject.Text;
                salary = Double.Parse(txtSalary.Text);

                this.mainForm.AddEmployee(fName, lName, position, salary, project);
            }

            Close();

        }
    }
}
