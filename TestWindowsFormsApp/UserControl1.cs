using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Repositories;
using DAL.Models;
using BUS.Helpers.ExtensionMethods;
using BUS.Views;
using System.Text.RegularExpressions;

namespace TestWindowsFormsApp
{
	public partial class UserControl1 : UserControl
	{
		private CustomerRepository customerRepository;
		private List<CustomerView> customerViews;
		private BindingSource customerSource;

		public UserControl1()
		{
			InitializeComponent();

			customerRepository = new CustomerRepository();
			customerSource = new BindingSource();

			bindSourceToDataGridView();
		}

		private void bindSourceToDataGridView()
		{
			customerViews = customerRepository.Customers.ConvertToViews().ToList();
			customerSource.DataSource = customerViews;
			dataGridView1.DataSource = customerSource;
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.Columns["SIMs"].Visible = false;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			refresh();
		}
		private void refresh()
		{
			txtName.Text = "";
			txtIDNumber.Text = "";
			txtEmail.Text = "";
			txtJob.Text = "";
			txtPosition.Text = "";
			txtAddress.Text = "";
			errorProvider1.Clear();
			btnRefresh.Visible = true;
			btnEdit.Visible = true;
			btnAdd.Visible = true;
			btnSave.Visible = false;
			btnCancel.Visible = false;
			customerSource.DataSource = customerRepository.Customers.ConvertToViews().ToList();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			txtName.Text = "";
			txtIDNumber.Text = "";
			txtEmail.Text = "";
			txtJob.Text = "";
			txtPosition.Text = "";
			txtAddress.Text = "";
			btnRefresh.Visible = false;
			btnEdit.Visible = false;
			btnAdd.Visible = false;
			btnSave.Visible = true;
			btnCancel.Visible = true;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Text = dataGridView1.CurrentRow.Cells[1].Value == null ? "" : dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtIDNumber.Text = dataGridView1.CurrentRow.Cells[2].Value == null ? "" : dataGridView1.CurrentRow.Cells[2].Value.ToString();
			txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value == null ? "" : dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtJob.Text = dataGridView1.CurrentRow.Cells[4].Value == null ? "" : dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtPosition.Text = dataGridView1.CurrentRow.Cells[5].Value == null ? "" : dataGridView1.CurrentRow.Cells[5].Value.ToString();
			txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value == null ? "" : dataGridView1.CurrentRow.Cells[6].Value.ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			Customer _customer = new Customer();
			_customer.Name = txtName.Text;
			_customer.CMND = txtIDNumber.Text;
			_customer.Email = txtEmail.Text;
			_customer.Job = txtJob.Text;
			_customer.Position = txtPosition.Text;
			_customer.Address = txtAddress.Text;
			customerRepository.EditCustomer(id, _customer);
			refresh();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validate())
			{
				errorProvider1.Clear();
				Customer newCustomer = new Customer();
				newCustomer.Id = 0;
				newCustomer.Name = txtName.Text;
				newCustomer.CMND = txtIDNumber.Text;
				newCustomer.Email = txtEmail.Text;
				newCustomer.Job = txtJob.Text;
				newCustomer.Position = txtPosition.Text;
				newCustomer.Address = txtAddress.Text;
				customerRepository.AddCustomer(newCustomer);
				refresh();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			refresh();
		}
		private bool validate()
		{
			errorProvider1.Clear();
			if (txtName.Text == "")
			{
				txtName.Focus();
				errorProvider1.SetError(txtName, MessageBox.Show("Hãy nhập tên của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			if (txtIDNumber.Text == "")
			{
				txtIDNumber.Focus();
				errorProvider1.SetError(txtIDNumber, MessageBox.Show("Hãy nhập CMND của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else
			{
				if (!Regex.IsMatch(txtIDNumber.Text, "^[0-9]{9}$|^[0-9]{12}$"))
				{
					txtIDNumber.Focus();
					errorProvider1.SetError(txtIDNumber, MessageBox.Show("CMND phải là 1 dãy 9 hoặc 12 chữ số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
					return false;
				}
				
			}
			if (txtEmail.Text == "")
			{
				txtEmail.Focus();
				errorProvider1.SetError(txtEmail, MessageBox.Show("Hãy nhập email của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else
			{
				if (!Regex.IsMatch(txtEmail.Text, "[a-z.0-9_-]+@[a-z]+\\.[a-z]{3,4}.*"))
				{
					txtEmail.Focus();
					errorProvider1.SetError(txtEmail, MessageBox.Show("Email không đúng định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
					return false;
				}
			}
			if (txtJob.Text == "")
			{
				txtJob.Focus();
				errorProvider1.SetError(txtJob, MessageBox.Show("Hãy nhập nghề nghiệp của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			if (txtPosition.Text == "")
			{
				txtPosition.Focus();
				errorProvider1.SetError(txtPosition, MessageBox.Show("Hãy nhập chức vụ của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			if (txtAddress.Text == "")
			{
				txtAddress.Focus();
				errorProvider1.SetError(txtAddress, MessageBox.Show("Hãy nhập địa chỉ của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			return true;
		}
		#region Validate
		private void txtName_Validating(object sender, CancelEventArgs e)
		{

		}

		private void txtIDNumber_Validating(object sender, CancelEventArgs e)
		{

		}

		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{

		}

		private void txtJob_Validating(object sender, CancelEventArgs e)
		{

		}

		private void txtPosition_Validating(object sender, CancelEventArgs e)
		{

		}

		private void txtAddress_Validating(object sender, CancelEventArgs e)
		{
			errorProvider1.SetError(txtAddress, MessageBox.Show("Hãy nhập địa chỉ của bạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
			e.Cancel = true;
		}
		#endregion
	}
}
