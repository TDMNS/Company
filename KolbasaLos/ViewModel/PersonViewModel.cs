using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using KolbasaLos.Helper;
using KolbasaLos.Model;
using KolbasaLos.View;

namespace KolbasaLos.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _selectedPerson;
        /// <summary>
        /// выделенные в списке данные по сотруднику
        /// </summary>
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        /// <summary>
        /// коллекция данных по сотрудникам
        /// </summary>
        public ObservableCollection<Person> ListPerson { get; set; }
        public ObservableCollection<PersonDpo> ListPersonDpo
        {
            get;
            set;
        }
        string _jsonPersons = String.Empty;
        public string Error { get; set; }
        public string Message { get; set; }
        public PersonViewModel()
        {
            ListPerson = new ObservableCollection<Person>();
            ListPerson = GetPersons();
        }
        private ObservableCollection<Person> GetPersons()
        {
            using (var context = new CompanyEntities())
            {
                var query = from per in context.Persons
                            .Include("Role")
                            orderby per.LastName
                            select per;
                if (query.Count() != 0)
                {
                    foreach (var p in query)
                    {
                        ListPerson.Add(p);
                    }
                }
            }
            return ListPerson;
        }

        #region AddPerson
        /// <summary>
        /// добавление сотрудника
        /// </summary>
        private RelayCommand _addPerson;
        /// <summary>
        /// добавление сотрудника
        /// </summary>
        public RelayCommand AddPerson
        {
            get
            {
                return _addPerson ??
                (_addPerson = new RelayCommand(obj =>
                {
                    Person newPerson = new Person
                    {
                        Birthday = DateTime.Now
                    };
                    WindowNewEmployee wnPerson = new WindowNewEmployee
                    {
                        Title = "Новый сотрудник",
                        DataContext = newPerson
                    };
                    wnPerson.CbRole.ItemsSource = new RoleViewModel().ListRole;
                    wnPerson.ShowDialog();
                    if (wnPerson.DialogResult == true)
                    {
                        using (var context = new CompanyEntities())
                        {
                            try
            
                {
                                Person ord = context.Persons.Add(newPerson);
                                context.SaveChanges();
                                ListPerson.Clear();
                                ListPerson = GetPersons();
                            }
               
                catch (Exception ex)
                            {
                                MessageBox.Show("\nОшибка добавления данных!\n" + ex.Message, "Предупреждение");
                            }
                        }
                    }
                }, (obj) => true));
            }
        }
        #endregion
        #region EditPerson
        /// команда редактирования данных по сотруднику
        private RelayCommand _editPerson;
        public RelayCommand EditPerson
        {
            get
            {
                return _editPerson ??
                (_editPerson = new RelayCommand(obj =>
                {
                    Person editPerson = SelectedPerson;
               
                WindowNewEmployee wnPerson = new WindowNewEmployee()
                {
                    Title = "Редактирование данных сотрудника",
                    DataContext = editPerson
                };

                    wnPerson.CbRole.ItemsSource = new RoleViewModel().ListRole;
                    wnPerson.ShowDialog();
                    if (wnPerson.DialogResult == true)
                    {
                        using (var context = new CompanyEntities())
                        {
                            Person person = context.Persons.Find(editPerson.Id);
                            if (person != null)
                            {
                                if (person.RoleId != editPerson.RoleId)
                                    person.RoleId = editPerson.RoleId;
                                if (person.FirstName != editPerson.FirstName)
                                    person.FirstName = editPerson.FirstName;
                                if (person.LastName != editPerson.LastName)
                                    person.LastName = editPerson.LastName;
                                if (person.Birthday != editPerson.Birthday)
                                    person.Birthday = editPerson.Birthday;
                                try
                                {
                                    context.SaveChanges();
                                    ListPerson.Clear();
                                    ListPerson = GetPersons();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("\nОшибка редактирования данных!\n" + ex.Message, "Предупреждение");
                                }
                            }
                        }
                    }
                    else
                    {
                        ListPerson.Clear();
                        ListPerson = GetPersons();
                    }
                }, (obj) => SelectedPerson != null && ListPerson.Count > 0));
            }
        }
        #endregion
        #region DeletePerson
        /// команда удаления данных по сотруднику
        private RelayCommand _deletePerson;
        public RelayCommand DeletePerson
        {
            get
            {
                return _deletePerson ??
                (_deletePerson = new RelayCommand(obj =>
                {
                    Person delPerson = SelectedPerson;
                    using (var context = new CompanyEntities())
                    {
                        // Поиск в контексте удаляемого автомобиля
                        Person person = context.Persons.Find(delPerson.Id);
                        if (person != null)
                        {
                            MessageBoxResult result = MessageBox.Show("Удалить данные по сотруднику: \nФамилия: " + person.LastName + "\nИмя: " + person.FirstName, "Предупреждение", MessageBoxButton.OKCancel);
                            if (result == MessageBoxResult.OK)
                            {
                                try
                                {
                                    context.Persons.Remove(person);
                                    context.SaveChanges();
                                    ListPerson.Remove(delPerson);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("\nОшибка удаления данных!\n" + ex.Message, "Предупреждение");
                                }
                            }
                        }
                    }
                }, (obj) => SelectedPerson != null && ListPerson.Count > 0));
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
