using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionFotm
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		/*private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}*/

		private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
		{
			double cost = Convert.ToDouble(domainUpDown1.SelectedItem) *Convert.ToDouble( numericUpDown1.Value);
			label6.Text = cost.ToString();
		}

		private void AddToCart_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox2.Text);
			
		}
	}
}
