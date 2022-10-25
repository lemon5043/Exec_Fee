using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultFee.Text = String.Empty;
			resultReason.Text = String.Empty;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				string age = textBox1.Text;
				int gender = CheckGender();
				resultFee.Text = CheckFee(age, gender).ToString();
				resultReason.Text = CheckReason(age, gender);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		int CheckGender()
		{
			if (rdoM.Checked) {return 1;}
			else if (rdoF.Checked) {return 0;}
			else
			{
				throw new Exception("請選擇性別");
			}
		}
		int CheckFee(string input, int gender)
		{
			bool isInt = int.TryParse(input, out int age);

			if (!isInt || age < 0 || age > 150)
			{
				throw new Exception("請輸入正確的年齡");
			}

			if (age <= 3)
			{
				return 0;
			} 
			else if (age >= 70 && gender == 1)
			{
				return 2;
			} 
			else if (age >= 60 && gender == 0)
			{
				return 3;
			}
			else
			{
				return 15;
			}
		}

		string CheckReason(string input, int gender)
		{
			int age = Convert.ToInt32(input);
			if (age <= 3)
			{
				return "小於3歲";
			}
			else if (age >= 70 && gender == 1)
			{
				return "超過70歲男性";
			}
			else if (age >= 60 && gender == 0)
			{
				return "超過60歲女性";
			}
			else
			{
				return "全票";
			}
		}
	}
}
