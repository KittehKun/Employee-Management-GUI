namespace Employee_Management_GUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listEmployees = new System.Windows.Forms.ListView();
            this.colHeaderName = new System.Windows.Forms.ColumnHeader();
            this.colHeaderPosition = new System.Windows.Forms.ColumnHeader();
            this.colHeaderSalary = new System.Windows.Forms.ColumnHeader();
            this.colHeaderProject = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolFileDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblFormFunctions = new System.Windows.Forms.Label();
            this.panelMetrics = new System.Windows.Forms.Panel();
            this.estimatedRevenue = new System.Windows.Forms.Label();
            this.lblEstimatedRevenue = new System.Windows.Forms.Label();
            this.employeeMVP = new System.Windows.Forms.Label();
            this.lblEmployeeMVP = new System.Windows.Forms.Label();
            this.grossProfitLoss = new System.Windows.Forms.Label();
            this.lblGrossProfitLoss = new System.Windows.Forms.Label();
            this.lblMetricTitle = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelMetrics.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmployees
            // 
            this.listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderName,
            this.colHeaderPosition,
            this.colHeaderSalary,
            this.colHeaderProject});
            this.listEmployees.GridLines = true;
            this.listEmployees.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listEmployees.Location = new System.Drawing.Point(24, 384);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(744, 161);
            this.listEmployees.TabIndex = 0;
            this.listEmployees.TabStop = false;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            this.listEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listEmployees_ItemSelectionChanged);
            // 
            // colHeaderName
            // 
            this.colHeaderName.Text = "Name";
            this.colHeaderName.Width = 150;
            // 
            // colHeaderPosition
            // 
            this.colHeaderPosition.Text = "Position";
            this.colHeaderPosition.Width = 150;
            // 
            // colHeaderSalary
            // 
            this.colHeaderSalary.Text = "Salary";
            this.colHeaderSalary.Width = 100;
            // 
            // colHeaderProject
            // 
            this.colHeaderProject.Text = "Project";
            this.colHeaderProject.Width = 340;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileDropdown,
            this.toolAddEmployee});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolFileDropdown
            // 
            this.toolFileDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolFileDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolFileDropdown.Image = ((System.Drawing.Image)(resources.GetObject("toolFileDropdown.Image")));
            this.toolFileDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFileDropdown.Name = "toolFileDropdown";
            this.toolFileDropdown.Size = new System.Drawing.Size(38, 22);
            this.toolFileDropdown.Text = "File";
            this.toolFileDropdown.ToolTipText = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.fileToolStripMenuItem.Text = "Exit";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolAddEmployee
            // 
            this.toolAddEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("toolAddEmployee.Image")));
            this.toolAddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddEmployee.Name = "toolAddEmployee";
            this.toolAddEmployee.Size = new System.Drawing.Size(33, 22);
            this.toolAddEmployee.Text = "Add";
            this.toolAddEmployee.ToolTipText = "Add";
            this.toolAddEmployee.Click += new System.EventHandler(this.toolAddEmployee_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Enabled = false;
            this.monthCalendar.Location = new System.Drawing.Point(536, 208);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.TabStop = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(544, 96);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(216, 40);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.TabStop = false;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblFormFunctions
            // 
            this.lblFormFunctions.AutoSize = true;
            this.lblFormFunctions.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormFunctions.Location = new System.Drawing.Point(576, 40);
            this.lblFormFunctions.Name = "lblFormFunctions";
            this.lblFormFunctions.Size = new System.Drawing.Size(157, 45);
            this.lblFormFunctions.TabIndex = 5;
            this.lblFormFunctions.Text = "Functions";
            // 
            // panelMetrics
            // 
            this.panelMetrics.BackColor = System.Drawing.Color.White;
            this.panelMetrics.Controls.Add(this.estimatedRevenue);
            this.panelMetrics.Controls.Add(this.lblEstimatedRevenue);
            this.panelMetrics.Controls.Add(this.employeeMVP);
            this.panelMetrics.Controls.Add(this.lblEmployeeMVP);
            this.panelMetrics.Controls.Add(this.grossProfitLoss);
            this.panelMetrics.Controls.Add(this.lblGrossProfitLoss);
            this.panelMetrics.Controls.Add(this.lblMetricTitle);
            this.panelMetrics.Location = new System.Drawing.Point(24, 48);
            this.panelMetrics.Name = "panelMetrics";
            this.panelMetrics.Size = new System.Drawing.Size(488, 316);
            this.panelMetrics.TabIndex = 6;
            // 
            // estimatedRevenue
            // 
            this.estimatedRevenue.AutoSize = true;
            this.estimatedRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estimatedRevenue.Location = new System.Drawing.Point(224, 152);
            this.estimatedRevenue.Name = "estimatedRevenue";
            this.estimatedRevenue.Size = new System.Drawing.Size(188, 30);
            this.estimatedRevenue.TabIndex = 6;
            this.estimatedRevenue.Text = "Kitteh Placeholder";
            // 
            // lblEstimatedRevenue
            // 
            this.lblEstimatedRevenue.AutoSize = true;
            this.lblEstimatedRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstimatedRevenue.Location = new System.Drawing.Point(16, 152);
            this.lblEstimatedRevenue.Name = "lblEstimatedRevenue";
            this.lblEstimatedRevenue.Size = new System.Drawing.Size(201, 30);
            this.lblEstimatedRevenue.TabIndex = 5;
            this.lblEstimatedRevenue.Text = "Estimated Revenue:";
            // 
            // employeeMVP
            // 
            this.employeeMVP.AutoSize = true;
            this.employeeMVP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeMVP.Location = new System.Drawing.Point(224, 112);
            this.employeeMVP.Name = "employeeMVP";
            this.employeeMVP.Size = new System.Drawing.Size(188, 30);
            this.employeeMVP.TabIndex = 4;
            this.employeeMVP.Text = "Kitteh Placeholder";
            // 
            // lblEmployeeMVP
            // 
            this.lblEmployeeMVP.AutoSize = true;
            this.lblEmployeeMVP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeMVP.Location = new System.Drawing.Point(16, 112);
            this.lblEmployeeMVP.Name = "lblEmployeeMVP";
            this.lblEmployeeMVP.Size = new System.Drawing.Size(166, 30);
            this.lblEmployeeMVP.TabIndex = 3;
            this.lblEmployeeMVP.Text = "Employee MVP:";
            // 
            // grossProfitLoss
            // 
            this.grossProfitLoss.AutoSize = true;
            this.grossProfitLoss.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grossProfitLoss.Location = new System.Drawing.Point(224, 72);
            this.grossProfitLoss.Name = "grossProfitLoss";
            this.grossProfitLoss.Size = new System.Drawing.Size(188, 30);
            this.grossProfitLoss.TabIndex = 2;
            this.grossProfitLoss.Text = "Kitteh Placeholder";
            // 
            // lblGrossProfitLoss
            // 
            this.lblGrossProfitLoss.AutoSize = true;
            this.lblGrossProfitLoss.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrossProfitLoss.Location = new System.Drawing.Point(16, 72);
            this.lblGrossProfitLoss.Name = "lblGrossProfitLoss";
            this.lblGrossProfitLoss.Size = new System.Drawing.Size(180, 30);
            this.lblGrossProfitLoss.TabIndex = 1;
            this.lblGrossProfitLoss.Text = "Gross Profit/Loss:";
            // 
            // lblMetricTitle
            // 
            this.lblMetricTitle.AutoSize = true;
            this.lblMetricTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTitle.Location = new System.Drawing.Point(120, 8);
            this.lblMetricTitle.Name = "lblMetricTitle";
            this.lblMetricTitle.Size = new System.Drawing.Size(269, 45);
            this.lblMetricTitle.TabIndex = 0;
            this.lblMetricTitle.Text = "Company Metrics";
            this.lblMetricTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelMetrics);
            this.Controls.Add(this.lblFormFunctions);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMetrics.ResumeLayout(false);
            this.panelMetrics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listEmployees;
        private ColumnHeader colHeaderName;
        private ColumnHeader colHeaderPosition;
        private ColumnHeader colHeaderSalary;
        private ColumnHeader colHeaderProject;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolFileDropdown;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripButton toolAddEmployee;
        private MonthCalendar monthCalendar;
        private Button btnAddEmployee;
        private Label lblFormFunctions;
        private Panel panelMetrics;
        private Label lblMetricTitle;
        private Label lblGrossProfitLoss;
        private Label grossProfitLoss;
        private Label employeeMVP;
        private Label lblEmployeeMVP;
        private Label estimatedRevenue;
        private Label lblEstimatedRevenue;
    }
}