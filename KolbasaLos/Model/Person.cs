using System;

namespace KolbasaLos.Model
{
    /// <summary>
    /// Класс сотрудник
    /// </summary>
    public class Person
    {
        /// <summary>
        /// код сотрудника
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// код должности сотрудника
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// имя сотрудника
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// фамилия сотрудника
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// дата рождения сотрудника
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// класс должности для связи с сущностью Role
        /// </summary>
        public virtual Role Role { get; set; }
    }
}
