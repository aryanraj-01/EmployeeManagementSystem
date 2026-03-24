using System.Text.Json;

namespace EmployeeManagementSystem;

public partial class Form1 : Form
{
    List<Employee> employees = new();
    int id = 1;

    public Form1()
    {
        InitializeComponent();
        LoadData();

        if (employees.Count > 0)
            id = employees.Max(x => x.Id) + 1;
    }

    void RefreshGrid()
    {
        gridEmployees.DataSource = null;
        gridEmployees.DataSource = employees;
    }

    void SaveData()
    {
        var json = JsonSerializer.Serialize(employees);
        File.WriteAllText("employees.json", json);
    }

    void LoadData()
    {
        if (File.Exists("employees.json"))
        {
            var json = File.ReadAllText("employees.json");
            var data = JsonSerializer.Deserialize<List<Employee>>(json);

            if (data != null)
                employees = data;

            gridEmployees.DataSource = employees;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Enter name");
            return;
        }

        if (!decimal.TryParse(txtSalary.Text, out decimal salary))
        {
            MessageBox.Show("Invalid salary");
            return;
        }

        var emp = new Employee
        {
            Id = id++,
            Name = txtName.Text,
            Salary = salary,
            Department = cmbDepartment.Text
        };

        employees.Add(emp);
        SaveData();
        RefreshGrid();
        ClearInputs();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (gridEmployees.CurrentRow == null) return;

        var emp = (Employee)gridEmployees.CurrentRow.DataBoundItem;
        employees.Remove(emp);

        SaveData();
        RefreshGrid();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (gridEmployees.CurrentRow == null) return;

        var emp = (Employee)gridEmployees.CurrentRow.DataBoundItem;

        emp.Name = txtName.Text;
        emp.Salary = Convert.ToDecimal(txtSalary.Text);
        emp.Department = cmbDepartment.Text;

        SaveData();
        RefreshGrid();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var result = employees
            .Where(x => x.Name.Contains(txtName.Text, StringComparison.OrdinalIgnoreCase))
            .ToList();

        gridEmployees.DataSource = null;
        gridEmployees.DataSource = result;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearInputs();
        RefreshGrid();
    }

    void ClearInputs()
    {
        txtName.Clear();
        txtSalary.Clear();
        cmbDepartment.SelectedIndex = -1;
    }

    private void gridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (gridEmployees.CurrentRow == null) return;

        var emp = (Employee)gridEmployees.CurrentRow.DataBoundItem;

        txtName.Text = emp.Name;
        txtSalary.Text = emp.Salary.ToString();
        cmbDepartment.Text = emp.Department;
    }

    private void gridEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        gridEmployees_CellClick(sender, e);
    }

    private void gridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}