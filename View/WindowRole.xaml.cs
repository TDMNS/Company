using System.Windows;
using KolbasaLos.ViewModel;
using KolbasaLos.Model;

namespace KolbasaLos.View
{
    /// <summary>
    /// Логика взаимодействия для WindowRole.xaml
    /// </summary>
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            DataContext = new RoleViewModel();
        }
    }
}
