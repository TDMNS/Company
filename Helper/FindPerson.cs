using System;
using KolbasaLos.Model;

namespace KolbasaLos.View
{
    internal class FindPerson
    {
        private int id;

        public FindPerson(int id)
        {
            this.id = id;
        }

        public bool PersonPredicate(Person person)
        {
            return person.Id == id;
        }
    }
}