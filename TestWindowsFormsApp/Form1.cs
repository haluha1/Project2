using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsFormsApp
{
	public partial class Form1 : Form
	{
		private UserControl1 uc1 = new UserControl1();
		private QLSdt uc2 = new QLSdt();
		public Form1()
		{
			InitializeComponent();

			Controls.Add(uc2);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
