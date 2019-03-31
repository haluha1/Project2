namespace TestWindowsFormsApp
{
	partial class UserControl1
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.FullName = new System.Windows.Forms.Label();
			this.IDNumber = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.Address = new System.Windows.Forms.Label();
			this.Position = new System.Windows.Forms.Label();
			this.Job = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtIDNumber = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtJob = new System.Windows.Forms.TextBox();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 230);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(813, 256);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(245, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách khách hàng";
			// 
			// FullName
			// 
			this.FullName.AutoSize = true;
			this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FullName.Location = new System.Drawing.Point(6, 47);
			this.FullName.Name = "FullName";
			this.FullName.Size = new System.Drawing.Size(56, 17);
			this.FullName.TabIndex = 2;
			this.FullName.Text = "Họ tên";
			// 
			// IDNumber
			// 
			this.IDNumber.AutoSize = true;
			this.IDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IDNumber.Location = new System.Drawing.Point(6, 87);
			this.IDNumber.Name = "IDNumber";
			this.IDNumber.Size = new System.Drawing.Size(52, 17);
			this.IDNumber.TabIndex = 3;
			this.IDNumber.Text = "CMND";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Email.Location = new System.Drawing.Point(6, 132);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(47, 17);
			this.Email.TabIndex = 4;
			this.Email.Text = "Email";
			// 
			// Address
			// 
			this.Address.AutoSize = true;
			this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Address.Location = new System.Drawing.Point(333, 132);
			this.Address.Name = "Address";
			this.Address.Size = new System.Drawing.Size(58, 17);
			this.Address.TabIndex = 5;
			this.Address.Text = "Địa chỉ";
			// 
			// Position
			// 
			this.Position.AutoSize = true;
			this.Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Position.Location = new System.Drawing.Point(333, 90);
			this.Position.Name = "Position";
			this.Position.Size = new System.Drawing.Size(66, 17);
			this.Position.TabIndex = 6;
			this.Position.Text = "Chức vụ";
			// 
			// Job
			// 
			this.Job.AutoSize = true;
			this.Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Job.Location = new System.Drawing.Point(333, 49);
			this.Job.Name = "Job";
			this.Job.Size = new System.Drawing.Size(100, 17);
			this.Job.TabIndex = 7;
			this.Job.Text = "Nghề nghiệp";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(68, 46);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(185, 20);
			this.txtName.TabIndex = 8;
			// 
			// txtIDNumber
			// 
			this.txtIDNumber.Location = new System.Drawing.Point(68, 87);
			this.txtIDNumber.Name = "txtIDNumber";
			this.txtIDNumber.Size = new System.Drawing.Size(185, 20);
			this.txtIDNumber.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(68, 132);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(185, 20);
			this.txtEmail.TabIndex = 10;
			// 
			// txtJob
			// 
			this.txtJob.Location = new System.Drawing.Point(439, 52);
			this.txtJob.Name = "txtJob";
			this.txtJob.Size = new System.Drawing.Size(185, 20);
			this.txtJob.TabIndex = 12;
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(439, 93);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(185, 20);
			this.txtPosition.TabIndex = 13;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(439, 132);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(185, 20);
			this.txtAddress.TabIndex = 14;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(710, 52);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 15;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(710, 90);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(710, 126);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 17;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(710, 52);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(710, 91);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.txtJob);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtIDNumber);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.Job);
			this.Controls.Add(this.Position);
			this.Controls.Add(this.Address);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.IDNumber);
			this.Controls.Add(this.FullName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(816, 489);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label FullName;
		private System.Windows.Forms.Label IDNumber;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label Address;
		private System.Windows.Forms.Label Position;
		private System.Windows.Forms.Label Job;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtIDNumber;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtJob;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
