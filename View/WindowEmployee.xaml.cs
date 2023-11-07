using System.Collections.ObjectModel;
using System.Windows;
using KolbasaLos.Model;
using KolbasaLos.ViewModel;

namespace KolbasaLos.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
