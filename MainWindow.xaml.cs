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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rozetka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ru_MouseEnter(object sender, MouseEventArgs e)
        {
            ru.Foreground = Brushes.Red;
        }

        private void ru_MouseLeave(object sender, MouseEventArgs e)
        {
            ru.Foreground = Brushes.White;
        }

        private void UA_MouseEnter(object sender, MouseEventArgs e)
        {
            UA.Foreground = Brushes.Red;
        }

        private void UA_MouseLeave(object sender, MouseEventArgs e)

        { 
            LinearGradientBrush myBrush = new LinearGradientBrush();
            myBrush.StartPoint = new Point(0.5,1);
            myBrush.EndPoint = new Point(0.5,0);
            myBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.7));
            myBrush.GradientStops.Add(new GradientStop(Colors.Blue, 0.3));
            UA.Foreground = myBrush;

        }
    }
}
