using EmployeeManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeManagementApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		EmployeeContext employeeContext = new EmployeeContext();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			int EmployeeId = int.Parse(txtEid.Text);
			string EmployeeName = txtEname.Text;
			string Location = txtLocation.Text;
			double Salary = double.Parse(txtSalary.Text);

			Employee employee = new Employee();
			employee.EmployeeId = EmployeeId;
			employee.EmployeeName = EmployeeName;
			employee.Location = Location;
			employee.Salary = Salary;

			
			employeeContext.Employees.Add(employee);
			employeeContext.SaveChanges();
			LoadEmployeeGrid();

			MessageBox.Show("Employee Added Successfully");
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			LoadEmployeeGrid();
		}
		private void LoadEmployeeGrid()
		{
			List<Employee> FetchedEmployees = (List<Employee>)employeeContext.Employees.ToList();
			datagrid.DataContext = FetchedEmployees;
		}

		private void btnsearch_Click(object sender, RoutedEventArgs e)
		{
			int EmployeeId = int.Parse(txtEid.Text);

			Employee emp = employeeContext.Employees.Find(EmployeeId);
			if (emp != null)
			{
				txtEname.Text = emp.EmployeeName;
				txtLocation.Text = emp.Location;
				txtSalary.Text = emp.Salary.ToString();
			}
			else
			{
				MessageBox.Show("Employee not found");
			}
		}

		private void btnUpdate_Click(object sender, RoutedEventArgs e)
		{
			int EmployeeId = int.Parse(txtEid.Text);
			Employee emp = employeeContext.Employees.Find(EmployeeId);
			if(emp!=null)
			{
				emp.EmployeeName = txtEname.Text;
				emp.Location = txtLocation.Text;
				emp.Salary = double.Parse(txtSalary.Text);

				employeeContext.SaveChanges();
				LoadEmployeeGrid();
				IsNull();
			}
		}

		public void IsNull()
		{
			txtEid.Text = string.Empty;
			txtEname.Text = string.Empty;
			txtLocation.Text = string.Empty;
			txtSalary.Text = string.Empty;
		}

		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			int EmployeeId = int.Parse(txtEid.Text);
			Employee emp = employeeContext.Employees.Find(EmployeeId);
			if (emp != null)
			{
				employeeContext.Employees.Remove(emp);
				employeeContext.SaveChanges();
				MessageBox.Show("Employee deleted successfully");
				LoadEmployeeGrid();
				IsNull();
			}
			else
			{
				MessageBox.Show("Employee Not found");
			}

		}
	}
	}

