using KolbasaLos.Helper;
using KolbasaLos.Model;
using System;
using System.Windows;

namespace KolbasaLos.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewEmployee.xaml
    /// </summary>
    public partial class WindowNewEmployee : Window
    {
        public WindowNewEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
