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
    /// Логика взаимодействия для Label.xaml
    /// </summary>
    public partial class Label : Page
    {
        public Label()
        {
            InitializeComponent();
        }

        private void Button_Clear(object sender,RoutedEventArgs e)
        {
            txtBlock.Text = String.Empty;
            textName.Clear();
        }
        
        private void Label_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                txtBlock.Text = String.Empty;
                MessageBox.Show("Text is empty",
                                this.Title,
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                string[] array = textName.Text.Split(' ');
                Array.Reverse(array);
                for (int i = 0; i < array.Length; i++)
                {
                    txtBlock.Text += $"{array[i]} ";
                }
            }
        }
    }
}
