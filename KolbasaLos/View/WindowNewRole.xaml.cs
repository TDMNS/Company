using System.Windows;
using System.Collections.Generic;
using KolbasaLos.Model;

namespace KolbasaLos.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewRole.xaml
    /// </summary>
    public partial class WindowNewRole : Window
    {
        public List<Role> ListRole { get; set; }
        public WindowNewRole()
        {
            InitializeComponent();
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListRole)
            {
                if (max < r.Id)
                {
                    max = r.Id;
                };
            }
            return max;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
