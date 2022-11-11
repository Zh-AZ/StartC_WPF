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
using System.Xml.Linq;

namespace StartC_WPF
{
    /// <summary>
    /// Логика взаимодействия для ListBox.xaml
    /// </summary>
    public partial class ListBox : Page
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            ListBoxer.Items.Clear();
            textName.Clear();
        }
        
        private void ListBox_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                ListBoxer.Items.Clear();
                MessageBox.Show("Text is empty",
                                this.Title,
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }

            else
            {
                ListBoxer.Items.Clear();
                string[] inputed = textName.Text.Split(' ');
                List<string> output = new List<string>();
                output.AddRange(inputed);
                for (int i = 0; i < output.Count; i++)
                {
                    ListBoxer.Items.Add(output[i]);
                }
            }
        }
    }
}
