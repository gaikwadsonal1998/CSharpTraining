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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int res = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
			label4.Text = res.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int res = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
			label4.Text = res.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int res = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
			label4.Text = res.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int res = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
			label4.Text = res.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//every control is a class
			foreach (Control c in this.Controls)
			{
				if(c is CheckBox)
				{
					Visible = true;
				}
				else
				c.Visible = false;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			foreach (Control c in this.Controls)
			{
				c.Visible = true;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			foreach (Control item in this.Controls)
			{
				if(item is TextBox)
				{
					item.Text = null;
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
		}
	}
}
