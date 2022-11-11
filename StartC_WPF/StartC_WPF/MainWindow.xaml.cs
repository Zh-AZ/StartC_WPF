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

namespace StartC_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBox p1;
        Label p2;
        public MainWindow()
        {
            InitializeComponent();
            p1 = new ListBox();
            p2 = new Label();
        }

        private void Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Button_Click_Label(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = p2;
        }
        
        private void Button_Click_ListBox(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = p1;
        }
        private void MyFrame_Navigated_ListBox(object sender, NavigationEventArgs e)
        {
        }

        private void MyFrame_Navigated_Label(object sender, NavigationEventArgs e)
        {
        }

        private void ListBox_MouseEnter(object sender, MouseEventArgs e)
        {
            Page2.Fill = Brushes.LightSkyBlue;
        }

        private void ListBox_MouseLeave(object sender, MouseEventArgs e)
        {
            Page2.Fill = Brushes.LightPink;
        }
        
        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            Page1.Fill = Brushes.LightSkyBlue;
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            Page1.Fill = Brushes.LightPink;
        }
    }
}
