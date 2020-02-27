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
	/// Select.xaml 的交互逻辑
	/// </summary>
	public partial class Select : Window {
		public Select() {
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e) {
			MainWindow window = new MainWindow();
			window.Show();
			Close();
		}

		private void button1_Click(object sender, RoutedEventArgs e) {
			Class_ShuChuang window = new Class_ShuChuang();
			window.Show();
			Close();
		}
	}
}
