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
using BUS.Views;
using BUS.Helpers.ExtensionMethods;
using System.Text.RegularExpressions;
using DAL.Models;

namespace TestWindowsFormsApp
{
	public partial class QLSdt : UserControl
	{
		private PhoneNumberRepository phoneNumberRepository;
		private List<PhoneNumberView> phoneNumberViews;
		private BindingSource phoneNumberSource;
		public QLSdt()
		{
			InitializeComponent();
			phoneNumberRepository = new PhoneNumberRepository();
			phoneNumberSource = new BindingSource();

			bindSourceToDataGridView();
		}
		private void bindSourceToDataGridView()
		{
			phoneNumberViews = phoneNumberRepository.PhoneNumbers.ConvertToViews().ToList();
			phoneNumberSource.DataSource = phoneNumberViews;
			dataGridView1.DataSource = phoneNumberSource;
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.Columns["SIMs"].Visible = false;
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtPhonenumber.Text = dataGridView1.CurrentRow.Cells[1].Value == null ? "" : dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtOwner.Text = dataGridView1.CurrentRow.Cells[2].Value == null ? "" : dataGridView1.CurrentRow.Cells[2].Value.ToString();
			
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			refresh();
		}
		private void refresh()
		{
			txtPhonenumber.Text = "";
			txtOwner.Text = "";
			errorProvider1.Clear();
			btnRefresh.Visible = true;
			btnEdit.Visible = true;
			btnAdd.Visible = true;
			btnSave.Visible = false;
			btnCancel.Visible = false;
			phoneNumberSource.DataSource = phoneNumberRepository.PhoneNumbers.ConvertToViews().ToList();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			txtPhonenumber.Text = "";
			txtOwner.Text = "";
			btnRefresh.Visible = false;
			btnEdit.Visible = false;
			btnAdd.Visible = false;
			btnSave.Visible = true;
			btnCancel.Visible = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validate())
			{
				errorProvider1.Clear();
				PhoneNumber newPhoneNumber = new PhoneNumber();
				newPhoneNumber.Id = 0;
				newPhoneNumber.Number = txtPhonenumber.Text;
				if (phoneNumberRepository.GetPhoneNumber(txtPhonenumber.Text)!=null)
				{
					errorProvider1.SetError(txtPhonenumber, MessageBox.Show("Số điện thoại đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				}
				else
				{
					phoneNumberRepository.AddPhoneNumber(newPhoneNumber);
					refresh();
				}
				
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			refresh();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			refresh();
		}
		private bool validate()
		{
			errorProvider1.Clear();
			if (txtPhonenumber.Text == "")
			{
				txtPhonenumber.Focus();
				errorProvider1.SetError(txtPhonenumber, MessageBox.Show("Hãy nhập số điện thoại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else
			{
				if (!Regex.IsMatch(txtPhonenumber.Text, "^[0-9]{8,12}$"))
				{
					txtPhonenumber.Focus();
					errorProvider1.SetError(txtPhonenumber, MessageBox.Show("Số điện thoại phải 1 chuỗi từ 8 đến 12 số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
					return false;
				}
			}
			return true;
		}
	}
}
