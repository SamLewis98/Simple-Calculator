using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
	public partial class calculator : Form
	{
		private decimal firstValue = 0.0m;
		private decimal secondValue = 0.0m;
		private decimal Result = 0.0m;
		private string operators = "+";
		public calculator()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn0_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "0";
			}
			else
			{
				TxtBox.Text += "0";

			}
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			if (!TxtBox.Text.Contains("."))
			{
				TxtBox.Text += ".";
			}
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "1";
			}
			else
			{
				TxtBox.Text += "1";
			}
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "2";
			}
			else
			{
				TxtBox.Text += "2";
			}
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "3";
			}
			else
			{
				TxtBox.Text += "3";
			}
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "4";
			}
			else
			{
				TxtBox.Text += "4";
			}
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "5";
			}
			else
			{
				TxtBox.Text += "5";
			}
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "6";
			}
			else
			{
				TxtBox.Text += "6";
			}
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "7";
			}
			else
			{
				TxtBox.Text += "7";
			}
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "8";
			}
			else
			{
				TxtBox.Text += "8";
			}
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			if (TxtBox.Text == "0")
			{
				TxtBox.Text = "9";
			}
			else
			{
				TxtBox.Text += "9";
			}
		}

		private void btnSubtractAdd_Click(object sender, EventArgs e) //Allows user to change between minus and positive numbers
		{
			if (TxtBox.Text.Contains("-"))
			{
				TxtBox.Text = TxtBox.Text.Trim('-');
			}
			else
			{
				TxtBox.Text = "-" + TxtBox.Text;
			}
		}

		private void btnSubtract_Click(object sender, EventArgs e)
		{
			firstValue = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "-";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			firstValue = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "+";
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			firstValue = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "/";
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			firstValue = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "*";
		}

		private void btnPercentage_Click(object sender, EventArgs e)
		{
			firstValue = decimal.Parse(TxtBox.Text);
			TxtBox.Clear();
			operators = "%";
		}

		private void BtnEquals_Click(object sender, EventArgs e)
		{
			switch (operators)
			{
				case "-":
					secondValue = decimal.Parse(TxtBox.Text);
					Result = firstValue - secondValue;
					TxtBox.Text = Result.ToString();
					break;

				case "+":
					secondValue = decimal.Parse(TxtBox.Text);
					Result = firstValue + secondValue;
					TxtBox.Text = Result.ToString();
					break;

				case "/":
					secondValue = decimal.Parse(TxtBox.Text);
					Result = firstValue / secondValue;
					TxtBox.Text = Result.ToString();
					break;

				case "*":
					secondValue = decimal.Parse(TxtBox.Text);
					Result = firstValue * secondValue;
					TxtBox.Text = Result.ToString();
					break;

				case "%":
					secondValue = decimal.Parse(TxtBox.Text);
					Result = firstValue % secondValue;
					TxtBox.Text = Result.ToString();
					break;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			firstValue = 0.0m;
			secondValue = 0.0m;
			TxtBox.Text = "0";
		}
	}
}
