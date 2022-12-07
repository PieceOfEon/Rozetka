using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    
   
    public partial class MainWindow : Window
    {
        private int kol = 1;
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

        private void Menu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kol++;
            if (kol == 8)
            {
                floor1.Visibility=Visibility.Hidden;
                //kol = 1;
            }
            else
            {
                floor1.Visibility = Visibility.Visible;
            }
            if (kol == 1)
            {
                imgContent.Content = Resources["Image.1"];
                floor1.Visibility = Visibility.Visible;
            }
            else if (kol == 2)
            {
                imgContent.Content = Resources["Image.2"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 3)
            {
                imgContent.Content = Resources["Image.3"];
            }
            else if (kol == 4)
            {
                imgContent.Content = Resources["Image.4"];
            }
            else if (kol == 5)
            {
                imgContent.Content = Resources["Image.5"];
            }
            else if (kol == 6)
            {
                imgContent.Content = Resources["Image.6"];
            }
            else if (kol == 7)
            {
                imgContent.Content = Resources["Image.7"];
            }
            else if (kol == 8)
            {
                imgContent.Content = Resources["Image.8"];
            }
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            kol--;
            if (kol == 1)
            {
                floor2.Visibility = Visibility.Hidden;
                //kol = 1;
            }
            else
            {
                floor1.Visibility = Visibility.Visible;
            }
            if (kol == 1)
            {
                imgContent.Content = Resources["Image.1"];
                floor1.Visibility = Visibility.Visible;
            }
            else if (kol == 2)
            {
                imgContent.Content = Resources["Image.2"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 3)
            {
                imgContent.Content = Resources["Image.3"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 4)
            {
                imgContent.Content = Resources["Image.4"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 5)
            {
                imgContent.Content = Resources["Image.5"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 6)
            {
                imgContent.Content = Resources["Image.6"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 7)
            {
                imgContent.Content = Resources["Image.7"];
                floor2.Visibility = Visibility.Visible;
            }
            else if (kol == 8)
            {
                imgContent.Content = Resources["Image.8"];
                floor2.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(borderItem.Visibility==Visibility.Visible)
            {
                borderItem.Visibility = Visibility.Hidden;
                borderBigMenu.Visibility = Visibility.Hidden;

            }
            else
            {
                borderItem.Visibility = Visibility.Visible;
                
            }
            
        }
        private void mmm2_MouseEnter(object sender, MouseEventArgs e)
        {
            borderBigMenu.Visibility = Visibility.Visible;
            MenuBigImage.ImageSource = new BitmapImage(new Uri("Image.8", UriKind.RelativeOrAbsolute));
        }
    }
}
