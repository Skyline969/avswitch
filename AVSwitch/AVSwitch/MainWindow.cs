using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVSwitch
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			// Adding video sources to the combo box
			this.cbVideoSource.DisplayMember = "Text";
			this.cbVideoSource.ValueMember = "Value";

			var items = new[] { 
				new { Text = "Internal", Value = "internal" }, 
				new { Text = "External", Value = "external" }, 
				new { Text = "Duplicate", Value = "clone" },
				new { Text = "Extend", Value = "extend" }
			};

			this.cbVideoSource.DataSource = items;
		}

		#region Switch Tab
		private void btnSwitch_Click(object sender, EventArgs e)
		{

		}

		private void btnVideoTest_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region Setup Tab
		private void btnNirCmdBrowse_Click(object sender, EventArgs e)
		{

		}

		private void btnDeleteConfiguration_Click(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
