using KolbasaLos.Model;
using KolbasaLos.ViewModel;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace KolbasaLos.Helper
{
    /// <summary>
    /// класс отображения данных по сотруднику
    /// </summary>
    public class PersonDpo : INotifyPropertyChanged
    {
        /// <summary>
        /// код сотрудника
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// должность сотрудника
        /// </summary>
        private string _roleName;
        /// <summary>
        /// должность сотрудника
        /// </summary>
        public string RoleName
        {
            get { return _roleName; }
            set
            {
                _roleName = value;
                OnPropertyChanged("RoleName");
            }
        }
        /// <summary>
        /// имя сотрудника
        /// </summary>
        private string firstName;
        /// <summary>
        /// имя сотрудника
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        /// <summary>
        /// фамилия сотрудника
        /// </summary>
        private string lastName;
        /// <summary>
        /// фамилия сотрудника
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        /// <summary>
        /// дата рождения сотрудника
        /// </summary>
        private string birthday;
        /// <summary>
        /// дата рождения сотрудника
        /// </summary>
        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        public PersonDpo() { }
        public PersonDpo(int id, string roleName, string firstName, string lastName, string birthday)
        {
            this.Id = id;
            this.RoleName = roleName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }
        /// <summary>
        /// Метод поверхностного копирования
        /// </summary>
        /// <returns></returns>
        public PersonDpo ShallowCopy()
        {
            return (PersonDpo)this.MemberwiseClone();
        }
        /// <summary>
        /// копирование данных из класса Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public PersonDpo CopyFromPerson(Person person)
        {
            PersonDpo perDpo = new PersonDpo();
            RoleViewModel vmRole = new RoleViewModel();
            Role role = vmRole.ListRole.FirstOrDefault(r => r.Id == person.RoleId);

            if (role != null)
            {
                perDpo.Id = person.Id;
                perDpo.RoleName = role.NameRole;
                perDpo.FirstName = person.FirstName;
                perDpo.LastName = person.LastName;
                perDpo.Birthday = person.Birthday;
            }
            return perDpo;
        }

        public static string GetStringBirthday(string birthday)
        {
            DateTime dateTime;
            if (DateTime.TryParseExact(birthday, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                return dateTime.ToString("dd.MM.yyyy");
            }
            return DateTime.Now.ToString("dd.MM.yyyy");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
