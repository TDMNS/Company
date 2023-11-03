using System.Windows;
using KolbasaLos.ViewModel;

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
            RoleViewModel vmRole = new RoleViewModel();
            lvRole.ItemsSource = vmRole.ListRole;
        }
    }
}
