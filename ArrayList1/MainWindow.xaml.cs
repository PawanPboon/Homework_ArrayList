using System;
using System.Collections;
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

namespace ArrayList1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }
        private void addData_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(textBox.Text);
            MessageBox.Show($"{textBox.Text} has been added.");

        }
        private void removeData_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(textBox.Text);
            MessageBox.Show($"{textBox.Text} has been removed.");
        }
        private void showData_Click(object sender, RoutedEventArgs e)
        {
            string dataName = string.Empty;
            foreach (var data in arrayList)
            {
                dataName += $"{data.ToString()}\n";
            }
            MessageBox.Show(dataName);
            
            MessageBox.Show("Count  " + arrayList.Count.ToString());
        }
    }
}
