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
using TemplateExample;

namespace TemplateExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush brush;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            string br = "\r\n";
            string allKeys=$"Все доступные ключи ресурсов:{br}", 
                allNames = $"{br}Все доступные имена ресурсов:{br}";
            foreach (var item in this.Resources.Keys) allKeys += $"{item}{br}";
            foreach (var item in this.Resources.Values) allNames += $"{item}{br}";
            MessageBox.Show(allNames + allKeys);
        }
        private void myButton_Click002(object sender, RoutedEventArgs e)
        {
            
            
             

            

        }
    }
}
