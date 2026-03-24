namespace EmployeeManagementSystem;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private TextBox txtName;
    private TextBox txtSalary;
    private ComboBox cmbDepartment;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnSearch;
    private Button btnClear;
    private DataGridView gridEmployees;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        txtName = new TextBox();
        txtSalary = new TextBox();
        cmbDepartment = new ComboBox();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnSearch = new Button();
        btnClear = new Button();
        gridEmployees = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)gridEmployees).BeginInit();
        SuspendLayout();
        // 
        // txtName
        // 
        txtName.Location = new Point(20, 20);
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Name";
        txtName.Size = new Size(200, 23);
        txtName.TabIndex = 0;
        // 
        // txtSalary
        // 
        txtSalary.Location = new Point(20, 60);
        txtSalary.Name = "txtSalary";
        txtSalary.PlaceholderText = "Salary";
        txtSalary.Size = new Size(200, 23);
        txtSalary.TabIndex = 1;
        // 
        // cmbDepartment
        // 
        cmbDepartment.Items.AddRange(new object[] { "IT", "HR", "Finance", "Sales" });
        cmbDepartment.Location = new Point(20, 100);
        cmbDepartment.Name = "cmbDepartment";
        cmbDepartment.Size = new Size(200, 23);
        cmbDepartment.TabIndex = 2;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(20, 140);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add";
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(100, 140);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Update";
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(200, 140);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 23);
        btnDelete.TabIndex = 5;
        btnDelete.Text = "Delete";
        btnDelete.Click += btnDelete_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(20, 180);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(75, 23);
        btnSearch.TabIndex = 6;
        btnSearch.Text = "Search";
        btnSearch.Click += btnSearch_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(100, 180);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 23);
        btnClear.TabIndex = 7;
        btnClear.Text = "Clear";
        btnClear.Click += btnClear_Click;
        // 
        // gridEmployees
        // 
        gridEmployees.Location = new Point(20, 220);
        gridEmployees.Name = "gridEmployees";
        gridEmployees.Size = new Size(1071, 250);
        gridEmployees.TabIndex = 8;
        gridEmployees.CellClick += gridEmployees_CellClick;
        gridEmployees.CellContentClick += gridEmployees_CellContentClick;
        gridEmployees.CellDoubleClick += gridEmployees_CellDoubleClick;
        // 
        // Form1
        // 
        ClientSize = new Size(1188, 511);
        Controls.Add(txtName);
        Controls.Add(txtSalary);
        Controls.Add(cmbDepartment);
        Controls.Add(btnAdd);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(btnSearch);
        Controls.Add(btnClear);
        Controls.Add(gridEmployees);
        Name = "Form1";
        Text = "Employee Management System";
        ((System.ComponentModel.ISupportInitialize)gridEmployees).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}