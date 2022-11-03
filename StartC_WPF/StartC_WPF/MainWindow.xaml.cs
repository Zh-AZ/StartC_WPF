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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Text is empty",
                                this.Title,
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                string[] inputed = txtName.Text.Split(' ');
                List<string> output = new List<string>();
                output.AddRange(inputed);
                ListBox.Items.Add(output);
            }
            
            //else
            //{
            //    MessageBox.Show($"Hello, {txtName.Text}!",
            //                    this.Title,
            //                    MessageBoxButton.YesNo,
            //                    MessageBoxImage.Information);
            //}
        }
    }
}
