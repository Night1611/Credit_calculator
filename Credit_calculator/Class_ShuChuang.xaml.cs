using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Credit_calculator {
	/// <summary>
	/// Class_ShuChuang.xaml 的交互逻辑
	/// </summary>
	public partial class Class_ShuChuang : Window {

		public Class_ShuChuang() {
			InitializeComponent();
		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
			try {
				double number = 6 - double.Parse(textBox.Text);
				if (number < 0) {
					number = 0;
				}
				textBlock1_Copy2.Text = number.ToString("#0.0");
				if (textBlock1_Copy2.Text == "0.0" && textBlock1_Copy3.Text == "0.0") {
					textBlock3.Text = ("已达标");
				}
				else {
					textBlock3.Text = ("未达标");
				}
			}
			catch {

			}
		}

		private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e) {
			try {
				double number = 4 - double.Parse(textBox_Copy.Text);
				if (number < 0) {
					number = 0;
				}
				textBlock1_Copy3.Text = number.ToString("#0.0");
				if (textBlock1_Copy2.Text == "0.0" && textBlock1_Copy3.Text == "0.0") {
					textBlock3.Text = ("已达标");
				}
				else {
					textBlock3.Text = ("未达标");
				}
			}
			catch {

			}
		}

		private void checkBox_Copy5_Checked(object sender, RoutedEventArgs e) {
			double sum = 0;
			if (checkBox_Copy5.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy6.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy7.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy8.IsChecked == true) {
				sum += 3.5;
			}
			if (checkBox_Copy9.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy10.IsChecked == true) {
				sum += 2.5;
			}
			if (checkBox_Copy11.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy12.IsChecked == true) {
				sum += 3;
			}
			if (checkBox_Copy13.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy14.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy15.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy16.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy17.IsChecked == true) {
				sum += 3;
			}
			if (checkBox_Copy18.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy19.IsChecked == true) {
				sum += 4;
			}
			if (checkBox_Copy20.IsChecked == true) {
				sum += 3;
			}

			textBlock1_Copy9.Text = sum.ToString("#0.0");
			double res = 10 - sum;
			if (res < 0) {
				res = 0;
			}
			textBlock1_Copy8.Text = res.ToString("#0.0");
			if (textBlock1_Copy8.Text == "0.0") {
				textBlock3_Copy1.Text = ("已达标");
			}
			else {
				textBlock3_Copy1.Text = ("未达标");
			}
		}

		private void checkBox_Copy5_Unchecked(object sender, RoutedEventArgs e) {
			checkBox_Copy5_Checked(sender, e);
		}

		private void checkBox_Copy23_Checked(object sender, RoutedEventArgs e) {
			double sum = 0;
			if (checkBox_Copy23.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy24.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy25.IsChecked == true) {
				sum += 3;
			}
			if (checkBox_Copy27.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy28.IsChecked == true) {
				sum += 2;
			}
			if (checkBox_Copy29.IsChecked == true) {
				sum += 2;
			}
			textBlock1_Copy12.Text = sum.ToString("#0.0");
			double res = 5 - sum;
			if (res < 0) {
				res = 0;
			}
			textBlock1_Copy11.Text = res.ToString("#0.0");
			if (textBlock1_Copy11.Text == "0.0") {
				textBlock3_Copy2.Text = ("已达标");
			}
			else {
				textBlock3_Copy2.Text = ("未达标");
			}
		}

		private void checkBox_Copy23_Unloaded(object sender, RoutedEventArgs e) {
			checkBox_Copy23_Checked(sender, e);
		}

		private void button_Click(object sender, RoutedEventArgs e) {
			About window = new About();
			window.Show();
		}

		private void button1_Click(object sender, RoutedEventArgs e) {
			Select window = new Select();
			window.Show();
			Close();
		}
	}
}
