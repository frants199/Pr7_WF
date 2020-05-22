using System;
using System.Text;
using System.Windows.Forms;

namespace Pr7_WF
{
	public partial class Pr7 : Form
	{
		public Pr7()
		{
			InitializeComponent();
		}
		private string ReplaceDots(string src, char dotCh, string dots, int minDotsCount)
		{
			StringBuilder dest = new StringBuilder();

			int i = 0;
			while (i < src.Length)
			{
				int dotsCount = 0;
				while (i < src.Length && src[i] == dotCh)
				{
					dotsCount++;
					i++;
				}
				if (dotsCount >= minDotsCount)
					dest.Append(dots);
				else if (dotsCount == 0)
					dest.Append(src[i++]);
				else
					while (dotsCount-- > 0)
						dest.Append(dotCh);
			}

			return dest.ToString(); ;
		}

		private void text1_box_TextChanged(object sender, EventArgs e)
		{
			try
			{
				
				string str = Convert.ToString(text1_box.Text);
				if (str == "") result1_box.Text="Пустая строка";
				else
				{
					string rez = ReplaceDots(str, '.', "...", 2);
					result1_box.Text = rez;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			Console.ReadLine();
		}
		private bool isPolyndrom(string input)
		{
			if (input.Length > 1)
			{
				char[] temp = input.ToCharArray();
				Array.Reverse(temp);
				if (input == new string(temp))
				{
					return true;
				}
			}
			return false;
		}
		private void text2_box_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string text = text2_box.Text;
				if (text == "") result2_box.Text = "Пустая строка";
				char[] separators = { ' ', ',', ':', ';', '.', '!', '?' };
				string[] splitedText = text.Split(separators);
				string polindroms = "";
				foreach (string str in splitedText)
				{
					if (str != null)
					{
						if (isPolyndrom(str))
						{
							polindroms += str + " ";
						}
					}
				}
				if (polindroms != "")
				{
					result2_box.Text=polindroms;
				}
				else result2_box.Text = "Палиндромов в строке нет";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
