using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CoursewareApp {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
          
        }

		private void FillButton_Click(object sender, RoutedEventArgs e) {
			var brush = new SolidColorBrush();
			brush.Color = Colors.Orange;

			Ellipse01.Fill = brush;

			var brush2 = new SolidColorBrush(Colors.Purple);

			Ellipse02.Fill = brush2;
			

		}

		private void StrokeButton_Click(object sender, RoutedEventArgs e) {
			var brush = new SolidColorBrush(Colors.DarkOrange);
			Ellipse01.Stroke = Ellipse02.Stroke = Ellipse03.Stroke = brush;

		}
	}
}